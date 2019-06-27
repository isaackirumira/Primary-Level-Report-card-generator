Imports MySql.Data.MySqlClient
Public Class COMPETENCES
    Public Sub getcompetencebysybject()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select competence from reportcards.competences where subject='" + txt_subject.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim classes As String = myReader.GetString("competence").ToString()


                RichTextBox1.Text = classes

            End While

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub fill_data_grid()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select competence from reportcards.competences ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim classes As String = myReader.GetString("competence").ToString()


                RichTextBox1.Text = classes

            End While

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub FILLSUBJECT()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select subject from reportcards.subjects ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim classes As String = myReader.GetString("subject").ToString()


                txt_subject.Items.Add(classes)

            End While

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub COMPETENCES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FILLSUBJECT()
        fill_data_grid()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ' Dim i2 As Integer

            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim con As New MySqlConnection(constring)
            Dim cmd As New MySqlCommand("INSERT INTO reportcards.competences(subject,competence,class,term) VALUES(@subject,@competence,@class,@term)", con)

            cmd.Parameters.AddWithValue("@subject", txt_subject.Text)
            cmd.Parameters.AddWithValue("@competence", RichTextBox1.Text)
            cmd.Parameters.AddWithValue("@class", txt_class.Text)
            cmd.Parameters.AddWithValue("@term", txt_term.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()


            MessageBox.Show("Competences Inserted.")
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        MessageBox.Show("Competences Inserted.")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Aa As String

        Aa = MsgBox("are you sure u want to delete this competence?", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_id.Text.Length > 0) Then

                Try




                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from reportcards.competences where id='" + txt_id.Text + "' ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Competence deleted")

                    fill_data_grid()


                    txt_subject.Text = ""
                    txt_id.Text = ""


                    mycon.Close()


                Catch ex As Exception
                    MessageBox.Show(ex.Message)




                End Try
            Else
                MessageBox.Show("None of the fields should be blank")
            End If


        Else



        End If
    End Sub

    Private Sub txt_subject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_subject.SelectedIndexChanged
        getcompetencebysybject()

    End Sub

   
    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
        txt_id.Text = RichTextBox1.Text
    End Sub

    Private Sub RichTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.Click
        txt_id.Text = RichTextBox1.Text
    End Sub
End Class