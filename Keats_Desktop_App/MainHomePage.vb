Imports IBM.Data.DB2
Public Class MainHomePage

    Private Sub PopulateDataGrid()
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


            While RdrSum.Read
                ' Order of Table
                ' 0 2ID
                ' 1 ACCOUNT_ID()
                ' 2 DATE_CREATED()
                ' 3 AMOUNT()
                ' 4 AMOUNT_UNIT()
                ' 5 AMOUNT_UNIT_DESC()
                ' 6 SERVING_SIZE()
                ' 7 INGREDIENT_MAPPING_ID()

                ' Get details of the ingredient item.
                ingredientMappingID = RdrSum.GetInt32(7)
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
                    StrSum = "Select * from ingredient where id=" & ingredientNameID
                    CmdSum = New DB2Command(StrSum, Globals.DBConnLogin)
                    RdrSum3 = CmdSum.ExecuteReader
                    RdrSum3.Read()
                    ingredientName = RdrSum3.GetString(1)

                    Try
                        ' Get Part (if applicable)
                        StrSum = "Select * from ingredient_variant where id=" & ingredientKindID
                        CmdSum = New DB2Command(StrSum, Globals.DBConnLogin)
                        RdrSum3 = CmdSum.ExecuteReader
                        RdrSum3.Read()
                        ingredientKind = RdrSum3.GetString(1) + " " 'Adds a space if exists
                    Catch ex As Exception

                    End Try

                    Try
                        ' Get Prep Type (if Applicable)
                        StrSum = "Select * from ingredient_subvariant where id=" & ingredientPrepID
                        CmdSum = New DB2Command(StrSum, Globals.DBConnLogin)
                        RdrSum3 = CmdSum.ExecuteReader
                        RdrSum3.Read()
                        ingredientPrep = RdrSum3.GetString(1) + " " 'Adds a space if exists
                    Catch ex As Exception

                    End Try

                    ' Get Nutrients
                    StrSum = "Select * from nutrient where id=" & ingredientNutrientID
                    CmdSum = New DB2Command(StrSum, Globals.DBConnLogin)
                    RdrSum3 = CmdSum.ExecuteReader
                    RdrSum3.Read()
                    ingredientNutrient = RdrSum3.GetFloat(5)

                Catch ex As Exception
                    MsgBox("Unknown Food Item")
                End Try


                ingredientName = "" & ingredientPrep & "" & ingredientKind & "" & ingredientName & ""
                row = New String() {RdrSum.GetString(2), ingredientName, RdrSum.GetString(3), ingredientNutrient}
                If DateDiff("d", RdrSum.GetDateTime(2), CurrentDate) = 0 Then
                    Me.DataGridView1.Rows.Add(row)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub MainHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.DataGridView1.ColumnCount = 4
            Me.DataGridView1.Columns(0).Name = "Time Recorded"
            Me.DataGridView1.Columns(1).Name = "Food"
            Me.DataGridView1.Columns(2).Name = "Serving Size (g)"
            Me.DataGridView1.Columns(3).Name = "Calories"
            Call PopulateDataGrid()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SearchIngredient.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class