Imports IBM.Data.DB2

Public Class SearchIngredient

    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        Dim SearchRes As String
        SearchRes = SearchBox.Text()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchResult.ColumnCount = 2
        Call PopulateDataGrid()
    End Sub

    Private Sub PopulateDataGrid()
        Dim StrStud As String
        Dim row As String()
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Try
            StrStud = "Select id, name from ingredient where UPPER(name) like UPPER('%" & SearchBox.Text() & "%')"
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

    Private Sub SearchResult_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SearchResult.CellClick
        ' Check if the click is on a valid row (not header or empty row)
        If e.RowIndex >= 0 AndAlso e.RowIndex < SearchResult.Rows.Count Then
            ' Access the clicked row using the RowIndex property
            Dim clickedRow As DataGridViewRow = SearchResult.Rows(e.RowIndex)

            ' Access the data in the row using the Cells property
            ' Dim cellValue As Object = clickedRow.Cells(1).Value
            ' Replace columnIndex with the index of the desired column

            Globals.SelectedIngredientId = clickedRow.Cells(0).Value
            IngredientDetails.Show()
        End If
    End Sub

    Private Sub SearchIngredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SearchResult_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles SearchResult.CellContentClick

    End Sub
End Class