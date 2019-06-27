Imports MySql.Data.MySqlClient
Public Class UpdateDivision
    Public Sub getcurrentdivision()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.best8 where year='" + RecordMarks.txt_year.Text + "' and term='" + RecordMarks.txt_term.Text + "' and class='" + RecordMarks.txt_class.Text + "'and Name='" + txt_name.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim currentdivision As String = myReader.GetString("DIVI").ToString()
                TextBox1.Text = currentdivision

            End While

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub fill_names()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.marks where year='" + RecordMarks.txt_year.Text + "' and term='" + RecordMarks.txt_term.Text + "' and class='" + RecordMarks.txt_class.Text + "' ;", mycon)
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

    Private Sub UpdateDivision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_names()
        txt_name.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_name.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim combData As New AutoCompleteStringCollection()
        getData(combData)
        txt_name.AutoCompleteCustomSource = combData
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ((RecordMarks.txt_term.Text.Length > 0) Or (RecordMarks.txt_class.Text.Length > 0) Or (RecordMarks.txt_year.Text.Length > 0)) Then
            Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("update reportcards.best8 set DIVI='" + ComboBox1.Text + "' where Name='" & txt_name.Text & "' and class='" + RecordMarks.txt_class.Text + "' and term='" + RecordMarks.txt_term.Text + "' and year='" + RecordMarks.txt_year.Text + "' ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()

                MessageBox.Show(" update division for  " & " " & txt_name.Text)


                mycon.Close()




            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else

            MessageBox.Show("Please first fill class , term and year on the following form in order to update " & " " & txt_name.Text & " " & "`" & " " & "Division")
        End If
    End Sub

    Private Sub txt_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_name.SelectedIndexChanged
        getcurrentdivision()
    End Sub
End Class