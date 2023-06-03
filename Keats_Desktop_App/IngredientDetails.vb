Imports IBM.Data.DB2
Imports System.Collections.Generic

Public Class IngredientDetails
     
    Dim IngredientVariants As New Dictionary(Of Integer, String)()
    Dim IngredientSubvariants As New Dictionary(Of Integer, String)()

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub PopulateIngredientMap()
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
            While RdrStud.Read
                Dim currKey As Integer = RdrStud.GetInt32(0)
                Dim currValue As String = RdrStud.GetString(1)
                If Not IngredientVariants.ContainsKey(currKey) Then
                    IngredientVariants.Add(currKey, currValue)
                    Console.WriteLine("Item added successfully.")
                Else
                    Console.WriteLine("Key already exists. Item not added.")
                End If
                row = New String() {RdrStud.GetString(0), RdrStud.GetString(1)}
                IngredientVariant.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub


    Private Sub IngredientDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ingId As Integer
        ingId = Globals.SelectedIngredientId
        If ingId > 0 Then
            Call PopulateIngredientMap()
        End If
    End Sub
End Class