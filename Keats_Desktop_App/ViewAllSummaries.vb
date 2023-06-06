Imports IBM.Data.DB2

Public Class ViewAllSummaries

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

        Dim Calories As Integer
        Dim Proteins As Integer
        Dim Carbs As Integer
        Dim Fats As Integer

        Dim Max_Calories As Integer
        Dim Max_Proteins As Integer
        Dim Max_Carbs As Integer
        Dim Max_Fats As Integer

        Dim CmdSum As DB2Command
        Dim RdrSum As DB2DataReader
        Dim RdrSum2 As DB2DataReader
        Dim RdrSum3 As DB2DataReader

        Try
            StrSum = "Select date_created, calories, protein, carbs, fats, max_calories, max_protein, max_carbs, max_fats from daily_nutrients where account_id=" & Globals.UserAccountID
            CmdSum = New DB2Command(StrSum, Globals.DBConnLogin)
            RdrSum = CmdSum.ExecuteReader
            Me.DataGridView1.Rows.Clear()

            While RdrSum.Read
                Calories = RdrSum.GetFloat(1)
                Proteins = RdrSum.GetFloat(2)
                Carbs = RdrSum.GetFloat(3)
                Fats = RdrSum.GetFloat(4)
                Max_Calories = RdrSum.GetFloat(5)
                Max_Proteins = RdrSum.GetFloat(6)
                Max_Carbs = RdrSum.GetFloat(7)
                Max_Fats = RdrSum.GetFloat(8)

                row = New String() {RdrSum.GetDateTime(0), _
                                    Calories & "/" & Max_Calories, _
                                    Proteins & "/" & Max_Proteins, _
                                    Carbs & "/" & Max_Carbs, _
                                    Fats & "/" & Max_Proteins}
                Me.DataGridView1.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox("Unknown Food Item")
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the click is on a valid row (not header or empty row)
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            ' Access the clicked row using the RowIndex property
            Dim clickedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Access the data in the row using the Cells property
            ' Dim cellValue As Object = clickedRow.Cells(1).Value
            ' Replace columnIndex with the index of the desired column

            Globals.TargetDate = clickedRow.Cells(0).Value
            ViewSummaryMeals.Show()
        End If
    End Sub

    Private Sub ViewAllSummaries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PopulateDataGrid()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        MainHomePage.Show()
        Me.Close()
    End Sub
End Class