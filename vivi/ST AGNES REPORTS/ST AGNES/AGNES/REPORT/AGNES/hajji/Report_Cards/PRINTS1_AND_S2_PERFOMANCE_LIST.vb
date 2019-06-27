Imports MySql.Data.MySqlClient
Public Class PRINTS1_AND_S2_PERFOMANCE_LIST

    Private Sub PRINTS1_AND_S2_PERFOMANCE_LIST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim myDataAdapter As MySqlDataAdapter = New MySqlDataAdapter()
            myDataAdapter.SelectCommand = New MySqlCommand("Select * from reportcards.positions;", mycon)
            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(myDataAdapter)
            mycon.Open()
            Dim ds As DataSet = New DataSet()
            myDataAdapter.Fill(ds)

            Dim crp As BESTRANKS = New BESTRANKS()
            crp.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crp
            CrystalReportViewer1.Show()
            CrystalReportViewer1.Refresh()
            mycon.Close()




        Catch ex As Exception

            MessageBox.Show(ex.Message)


        End Try
    End Sub
End Class