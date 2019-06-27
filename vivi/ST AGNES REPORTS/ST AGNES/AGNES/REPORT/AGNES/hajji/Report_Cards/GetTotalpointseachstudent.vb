Imports MySql.Data.MySqlClient
Public Class GetTotalpointseachstudent
    Public Sub updatealeveltotalpointsinaleveltbl()
        Try




            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("update reportcards.aleveltotalpoints set totalpoints='" + txt_totalpoints.Text + "' where name='" & txt_name.Text & "' and class='" + RecordMarksALevel.txt_class.Text + "' and term='" + RecordMarksALevel.txt_term.Text + "' and year='" + RecordMarksALevel.txt_year.Text + "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()

            myReader = SelectCommand.ExecuteReader()
            Label6.Text = "Total points for" & " " & RecordMarksALevel.txt_class.Text & " " & "Updated,now make  you can print reports"
            Label6.Visible = True

            txt_totalpoints.Text = "0"



            mycon.Close()




        Catch ex As Exception
            MessageBox.Show(ex.Message)




        End Try
    End Sub
    Public Sub gettotalpoints()
        Try
            Dim i As Integer = 0
            Dim tot As Double = 0
            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            Do Until i = DataGridView1.Rows.Count
                tot = tot + DataGridView1.Rows(i).Cells(3).Value
                i = i + 1
            Loop
            txt_totalpoints.Text = tot.ToString()



        Catch ex As Exception
            '   MessageBox.Show(ex.Message)


        End Try
    End Sub
    Public Sub fill_names()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.aleveltotalpoints where year='" + RecordMarksALevel.txt_year.Text + "' and term='" + RecordMarksALevel.txt_term.Text + "' and class='" + RecordMarksALevel.txt_class.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim name As String = myReader.GetString("name").ToString()
                txt_name.Items.Add(name)

            End While

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub
    Public Sub autofillgrid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select name,class,subject,POINTS from reportcards.aleveltotalpoints where name='" + txt_name.Text + "' and year='" + RecordMarksALevel.txt_year.Text + "' and term='" + RecordMarksALevel.txt_term.Text + "' and class='" + RecordMarksALevel.txt_class.Text + "' and POINTS<>'-' and POINTS<>'x'  order by POINTS asc ;", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource
            sda.Update(dbDataset)
            conDatabase.Close()



        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub getData(ByVal dataCollection As AutoCompleteStringCollection)
        Dim connetionString As String = Nothing
        Dim connection As MySqlConnection
        Dim command As MySqlCommand
        Dim adapter As New MySqlDataAdapter()
        Dim ds As New DataSet()
        connetionString = "datasource=localhost;port=3306;username=root;"
        Dim sql As String = "Select distinct(name) from reportcards.students"
        connection = New MySqlConnection(connetionString)
        Try
            connection.Open()
            command = New MySqlCommand(sql, connection)
            adapter.SelectCommand = command
            adapter.Fill(ds)
            adapter.Dispose()
            command.Dispose()
            connection.Close()
            For Each row As DataRow In ds.Tables(0).Rows
                dataCollection.Add(row(0).ToString())
            Next

        Catch ex As Exception
            MessageBox.Show("Can not open connection ! ")
        End Try
    End Sub
    Private Sub GetTotalpointseachstudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_names()
        txt_name.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_name.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim combData As New AutoCompleteStringCollection()
        getData(combData)
        txt_name.AutoCompleteCustomSource = combData
    End Sub

    Private Sub txt_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_name.SelectedIndexChanged
        autofillgrid()
        gettotalpoints()

        updatealeveltotalpointsinaleveltbl()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub DataGridView1_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        Try
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        Try
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_totalpoints_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_totalpoints.TextChanged
        SendKeys.Send("{down}")
    End Sub
End Class