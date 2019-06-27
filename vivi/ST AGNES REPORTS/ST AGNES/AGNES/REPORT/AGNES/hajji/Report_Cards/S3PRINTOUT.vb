Imports MySql.Data.MySqlClient
Public Class S3PRINTOUT

    Private Sub S3PRINTOUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim myDataAdapter As MySqlDataAdapter = New MySqlDataAdapter()
            myDataAdapter.SelectCommand = New MySqlCommand("Select * from reportcards.marks;", mycon)
            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(myDataAdapter)
            mycon.Open()
            Dim ds As DataSet = New DataSet()
            myDataAdapter.Fill(ds)
            'Dim crp As CLASSREPS3 = New CLASSREPS3()
            Dim crp As ISAAC = New ISAAC()
            ' Dim crp As CAANDMIDS1 = New CAANDMIDS1()
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