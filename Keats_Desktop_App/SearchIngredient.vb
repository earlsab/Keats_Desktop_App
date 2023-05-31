Public Class SearchIngredient
     
    Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.TextChanged
        Dim SearchRes As String
        SearchRes = SearchBox.Text()
        Query.Text = SearchRes

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Query_Click(sender As Object, e As EventArgs) Handles Query.Click

    End Sub
End Class