﻿Imports MySql.Data.MySqlClient
Public Class marksheets1s2

    Private Sub marksheets1s2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim myDataAdapter As MySqlDataAdapter = New MySqlDataAdapter()
            myDataAdapter.SelectCommand = New MySqlCommand("Select * from reportcards.marks;", mycon)
            Dim cb As MySqlCommandBuilder = New MySqlCommandBuilder(myDataAdapter)
            mycon.Open()
            Dim ds As DataSet = New DataSet()
            myDataAdapter.Fill(ds)
            Dim crp As generalmarksheets1s2 = New generalmarksheets1s2()
            crp.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = crp
            CrystalReportViewer1.Show()
            CrystalReportViewer1.Refresh()
            mycon.Close()




        Catch ex As Exception

            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class