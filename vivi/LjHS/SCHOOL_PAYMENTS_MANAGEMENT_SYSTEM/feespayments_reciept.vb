Imports MySql.Data.MySqlClient
Public Class feespayments_reciept

    Private Sub DIAGONOSIS_REPORT_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim myDataAdapter As MySqlDataAdapter = New MySqlDataAdapter()
            myDataAdapter.SelectCommand = New MySqlCommand("Select * from school_payments.installments;", mycon)
            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(myDataAdapter)
            mycon.Open()
            Dim ds As DataSet = New DataSet()
            myDataAdapter.Fill(ds)
            Dim crp As receiptfees = New receiptfees()
            crp.SetDataSource(ds)
            crp.SetParameterValue("name", Form4.txt_name.Text)
            crp.SetParameterValue("class", Form4.txt_class.Text)
            crp.SetParameterValue("term", Form4.txt_term.Text)
            crp.SetParameterValue("year", Form4.txt_year.Text)

            CrystalReportViewer1.ReportSource = crp
            CrystalReportViewer1.Show()
            CrystalReportViewer1.Refresh()
            mycon.Close()




        Catch ex As Exception

            MessageBox.Show(ex.Message)


        End Try

    End Sub
End Class