Imports IBM.Data.DB2
Public Class MainHomePage

    Private Sub PopulateDataGrid()
        Dim StrStud As String
        Dim row As String()
        Dim CmdStud As DB2Command
        Dim RdrStud As DB2DataReader
        Try
            StrStud = "Select * from intake"
            CmdStud = New DB2Command(StrStud, Globals.DBConnLogin)
            RdrStud = CmdStud.ExecuteReader
            Me.DataGridView1.Rows.Clear()
            While RdrStud.Read
                row = New String() {RdrStud.GetString(2), RdrStud.GetString(5), _
                                   RdrStud.GetString(4)}  ' NOT REPRESENTATIVE OF THE DATABASE. Change later
                Me.DataGridView1.Rows.Add(row)
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
            Me.DataGridView1.Columns(2).Name = "Serving Size"
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
End Class