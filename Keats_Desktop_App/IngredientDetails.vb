Imports IBM.Data.DB2
Imports System.Collections.Generic

Public Class IngredientDetails
    Dim FirstIngredientVariantId As Integer
    Dim FirstIngredientSubvariantId As Integer

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

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
            StrStud = "select nutrient.calories, nutrient.protein, nutrient.carbs, nutrient.fats " _
                & "FROM ingredient_mapping " _
                & "JOIN nutrient ON ingredient_mapping.nutrient_id = nutrient.id " _
                & "WHERE ingredient_mapping.ingredient_id = " & Globals.SelectedIngredientId & " " _
                & "AND ingredient_mapping.ingredient_variant_id = " & FirstIngredientVariantId & " " _
                & "AND ingredient_mapping.ingredient_subvariant_id = " & FirstIngredientSubvariantId & ";"
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            RdrStud = CmdStud.ExecuteReader 
            While RdrStud.Read
                CaloriesValue.Text() = RdrStud.GetString(0)
                ProteinValue.Text() = RdrStud.GetString(1)
                CarbsValue.Text() = RdrStud.GetString(2)
                FatsValue.Text() = RdrStud.GetString(3)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Private Sub IngredientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ingId As Integer
        ingId = Globals.SelectedIngredientId
        If Not ingId = 0 Then
            Call PopulateIngredientVariant()
            Call RetrieveIngredient()
            Call PopulateIngredientSubvariant()
            Call PopulateNutrients()
        End If
    End Sub
     
End Class