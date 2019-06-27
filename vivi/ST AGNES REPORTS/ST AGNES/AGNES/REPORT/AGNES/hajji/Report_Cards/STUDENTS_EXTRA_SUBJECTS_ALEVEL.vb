Imports MySql.Data.MySqlClient
Public Class STUDENTS_EXTRA_SUBJECTS_ALEVEL
    Public Sub fill_classes()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.classes ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim classes As String = myReader.GetString("class").ToString()


                txt_class.Items.Add(classes)

            End While

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try


    End Sub
    Public Sub deleteolevel()
        Dim Aa As String

        Aa = MsgBox("are you sure u want to delete marks for this subject?", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_subject.Text.Length > 0) Then

                Try




                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from reportcards.marks where name='" + txt_student.Text + "' and subject='" + txt_subject.Text + "' and class='" + txt_class.Text + "' and year='" + txt_year.Text + "' and term='" + txt_term.Text + "'  ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Extra Subject deleted")



                    mycon.Close()


                Catch ex As Exception
                    'MessageBox.Show(ex.Message)




                End Try
            Else
                MessageBox.Show("Subject can not be  blank")
            End If


        Else



        End If
    End Sub
    Public Sub deletealevel()
        Dim Aa As String

        Aa = MsgBox("are you sure u want to delete marks for this subject? Comfirm", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_subject.Text.Length > 0) Then

                Try




                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from reportcards.aleveltotalpoints where name='" + txt_student.Text + "' and subject='" + txt_subject.Text + "' and class='" + txt_class.Text + "' and year='" + txt_year.Text + "' and term='" + txt_term.Text + "'  ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Extra Subject deleted Just go back to reports and print out its ok now")

                    
                    mycon.Close()


                Catch ex As Exception
                    'MessageBox.Show(ex.Message)




                End Try
            Else
                MessageBox.Show("Subject can not be  blank")
            End If


        Else



        End If
    End Sub
    Public Sub subjo()
        Try


            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select NAME,SUBJECT from reportcards.marks where NAME='" + Me.txt_student.Text + "' and class='" + Me.txt_class.Text + "' and year='" + Me.txt_year.Text + "';", conDatabase)
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
            ' MessageBox.Show("Fill password , class and year to search records")


        End Try

    End Sub
    Public Sub subja()
        Try


            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select NAME,SUBJECT from reportcards.aleveltotalpoints where NAME='" + Me.txt_student.Text + "' and class='" + Me.txt_class.Text + "' and year='" + Me.txt_year.Text + "';", conDatabase)
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
            ' MessageBox.Show("Fill password , class and year to search records")


        End Try

    End Sub
    Public Sub fill_grid()
       
    End Sub
    Public Sub fill_studets2()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select distinct(name) from reportcards.marks where year='" + txt_year.Text + "' and term='" + txt_term.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim name As String = myReader.GetString("name").ToString()


                txt_student.Items.Add(name)

            End While

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try


    End Sub
    Public Sub fill_studets()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select distinct(name) from reportcards.aleveltotalpoints where year='" + txt_year.Text + "' and term='" + txt_term.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim name As String = myReader.GetString("name").ToString()


                txt_student.Items.Add(name)

            End While

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try


    End Sub
    Private Sub getDataol(ByVal dataCollection As AutoCompleteStringCollection)

        Dim connetionString As String = Nothing
        Dim connection As MySqlConnection
        Dim command As MySqlCommand
        Dim adapter As New MySqlDataAdapter()
        Dim ds As New DataSet()
        connetionString = "datasource=localhost;port=3306;username=root;"
        Dim sql As String = "Select distinct(name) from reportcards.marks where year='" + txt_year.Text + "' and term='" + txt_term.Text + "'"
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
    Private Sub getDataal(ByVal dataCollection As AutoCompleteStringCollection)

        Dim connetionString As String = Nothing
        Dim connection As MySqlConnection
        Dim command As MySqlCommand
        Dim adapter As New MySqlDataAdapter()
        Dim ds As New DataSet()
        connetionString = "datasource=localhost;port=3306;username=root;"
        Dim sql As String = "Select distinct(name) from reportcards.aleveltotalpoints where year='" + txt_year.Text + "' and term='" + txt_term.Text + "'"
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
    Private Sub STUDENTS_EXTRA_SUBJECTS_ALEVEL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_classes()

       

    End Sub

    Private Sub txt_student_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_student.SelectedIndexChanged
     
    End Sub

    Private Sub txt_class_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_class.SelectedIndexChanged
      

        fill_studets()
        fill_studets2()
    End Sub

    Private Sub txt_year_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_year.TextChanged
  
        fill_studets()
        fill_studets2()
    End Sub

    Private Sub txt_term_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_term.SelectedIndexChanged
        fill_studets()
        fill_studets2()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Me.txt_subject.Text = DataGridView1.Item(1, i).Value

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        deleteolevel()
        deletealevel()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
      
    End Sub

    Private Sub txt_subject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_subject.SelectedIndexChanged

    End Sub
End Class