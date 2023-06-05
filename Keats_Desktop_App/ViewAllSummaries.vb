Imports IBM.Data.DB2

Public Class ViewAllSummaries

    Private Sub PopulateDataGrid()

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the click is on a valid row (not header or empty row)
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            ' Access the clicked row using the RowIndex property
            Dim clickedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Access the data in the row using the Cells property
            ' Dim cellValue As Object = clickedRow.Cells(1).Value
            ' Replace columnIndex with the index of the desired column

            Globals.SelectedIngredientId = clickedRow.Cells(0).Value
            EditSpecificIntake.Show()
        End If
    End Sub

    Private Sub ViewAllSummaries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class