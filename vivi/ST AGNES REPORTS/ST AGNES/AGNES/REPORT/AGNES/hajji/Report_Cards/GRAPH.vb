Imports MySql.Data.MySqlClient
Public Class GRAPH
    Dim dbconn As New MySqlConnection
    Dim dbcomm As MySqlCommand
    Dim dbread As MySqlDataReader

    Private Sub graphLoadData()
        dbconn = New MySqlConnection("Data Source=localhost;user id=root; database=reportcards;")

        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Error in connection, please check Database and connection server.")
        End Try
        Dim sql As String

        Try

            Chart1.Series.Add("NAME")
            Chart1.Series.Add("AVERAGE")
            sql = "select Name,average from reportcards.marks WHERE CLASS='S1 EAST' AND TERM='TWO' group by name  asc"
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()
            While dbread.Read
                Chart1.Series("NAME").Points.AddXY(dbread("Name").ToString, dbread("Average").ToString)

            End While
            dbread.Close()
        Catch ex As Exception
            MsgBox("Error in saving to Database. Error is :" & ex.Message)
            dbread.Close()
            Exit Sub
        Finally
            dbread.Close()
            dbconn.Dispose()
        End Try
    End Sub
    Private Sub GRAPH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        graphLoadData()
    End Sub
End Class