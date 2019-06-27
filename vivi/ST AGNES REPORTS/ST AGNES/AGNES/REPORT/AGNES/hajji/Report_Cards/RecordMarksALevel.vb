Imports MySql.Data.MySqlClient
Public Class RecordMarksALevel

    Dim WithEvents txt1 As TextBox
    ''' olevel grading
    Dim v1 As String = "D1"
    Dim s1 As String = "1"
    Dim r1 As String = "Very Good"
    Dim v2 As String = "D2"
    Dim s2 As String = "2"
    Dim r2 As String = "Good"
    Dim v3 As String = "C3"
    Dim s3 As String = "3"
    Dim r3 As String = "Aim Higher"
    Dim v4 As String = "C4"
    Dim s4 As String = "4"
    Dim r4 As String = "Double Effort"
    Dim v5 As String = "C5"
    Dim s5 As String = "5"
    Dim r5 As String = "Double Effort"
    Dim v6 As String = "C6"
    Dim s6 As String = "6"
    Dim r6 As String = "Double Effort"
    Dim v7 As String = "P7"
    Dim s7 As String = "7"
    Dim r7 As String = "Work Harder"
    Dim v8 As String = "P8"
    Dim s8 As String = "8"
    Dim r8 As String = "Work Harder"
    Dim v9 As String = "F9"
    Dim s9 As String = "9"
    Dim r9 As String = "Work Harder"
    ''' olevel grading ends
    ''' alevel grading
    Dim a1 As String = "A"
    Dim b1 As String = "6"
    Dim c1 As String = "Very Good"
    Dim a2 As String = "B"
    Dim b2 As String = "5"
    Dim c2 As String = "Good"
    Dim a3 As String = "C"
    Dim b3 As String = "4"
    Dim c3 As String = "Aim Higher"
    Dim a4 As String = "D"
    Dim b4 As String = "3"
    Dim c4 As String = "Double Effort"
    Dim a5 As String = "E"
    Dim b5 As String = "2"
    Dim c5 As String = "Double Effort"
    Dim a6 As String = "O"
    Dim b6 As String = "1"
    Dim c6 As String = "Work Harder"
    Dim a7 As String = "F9"
    Dim b7 As String = "0"
    Dim c7 As String = "More Effort"

    ''' alevel grading ends



    Dim v10 As String = "-"
    Dim s10 As String = "-"
    Dim r10 As String = "Missed Paper"

    Dim tb As TextBox
    Dim maxid As String
    Dim entryid As String

    Public Sub FILLcode()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select code,P1,P2,P3,P4 from reportcards.subjecta where subject='" + txt_subject.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim classes As String = myReader.GetString("code").ToString()
                Dim P11 As String = myReader.GetString("P1").ToString()
                Dim P22 As String = myReader.GetString("P2").ToString()
                Dim P33 As String = myReader.GetString("P3").ToString()
                Dim P44 As String = myReader.GetString("P4").ToString()

                txt_code.Text = classes
                P1.Text = P11
                P2.Text = P22
                P3.Text = P33
                P4.Text = P44
            End While

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub


    Public Sub setgradep4midNOBOT()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index


            DataGridView1.Item(21, i2).Value = Double.Parse(DataGridView1.Item(19, i2).Value)



            If (Double.Parse(DataGridView1.Item(21, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 100) Then
                DataGridView1.Item(22, i2).Value = v1
                DataGridView1.Item(23, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 89.5) Then
                DataGridView1.Item(22, i2).Value = v2
                DataGridView1.Item(23, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 79.5) Then
                DataGridView1.Item(22, i2).Value = v3
                DataGridView1.Item(23, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 69.5) Then
                DataGridView1.Item(22, i2).Value = v4
                DataGridView1.Item(23, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 64.5) Then
                DataGridView1.Item(22, i2).Value = v5
                DataGridView1.Item(23, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 59.5) Then
                DataGridView1.Item(22, i2).Value = v6
                DataGridView1.Item(23, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 49.5) Then
                DataGridView1.Item(22, i2).Value = v7
                DataGridView1.Item(23, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 44.5) Then
                DataGridView1.Item(22, i2).Value = v8
                DataGridView1.Item(23, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 39.5) Then
                DataGridView1.Item(22, i2).Value = v9
                DataGridView1.Item(23, i2).Value = s9




            Else
                DataGridView1.Item(22, i2).Value = v10
                DataGridView1.Item(23, i2).Value = s10





            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub setgradep4ALLSETSAVAILABLE()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index


            DataGridView1.Item(21, i2).Value = (Double.Parse(DataGridView1.Item(19, i2).Value) + Double.Parse(DataGridView1.Item(20, i2).Value)) / 2



            If (Double.Parse(DataGridView1.Item(21, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 100) Then
                DataGridView1.Item(22, i2).Value = v1
                DataGridView1.Item(23, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 89.5) Then
                DataGridView1.Item(22, i2).Value = v2
                DataGridView1.Item(23, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 79.5) Then
                DataGridView1.Item(22, i2).Value = v3
                DataGridView1.Item(23, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 69.5) Then
                DataGridView1.Item(22, i2).Value = v4
                DataGridView1.Item(23, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 64.5) Then
                DataGridView1.Item(22, i2).Value = v5
                DataGridView1.Item(23, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 59.5) Then
                DataGridView1.Item(22, i2).Value = v6
                DataGridView1.Item(23, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 49.5) Then
                DataGridView1.Item(22, i2).Value = v7
                DataGridView1.Item(23, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 44.5) Then
                DataGridView1.Item(22, i2).Value = v8
                DataGridView1.Item(23, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 39.5) Then
                DataGridView1.Item(22, i2).Value = v9
                DataGridView1.Item(23, i2).Value = s9


            Else
                DataGridView1.Item(22, i2).Value = v10
                DataGridView1.Item(23, i2).Value = s10


            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub setgradep4()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index


            DataGridView1.Item(21, i2).Value = (Double.Parse(DataGridView1.Item(19, i2).Value) + Double.Parse(DataGridView1.Item(20, i2).Value)) / 2



            If (Double.Parse(DataGridView1.Item(21, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 100) Then
                DataGridView1.Item(22, i2).Value = v1
                DataGridView1.Item(23, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 89.5) Then
                DataGridView1.Item(22, i2).Value = v2
                DataGridView1.Item(23, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 79.5) Then
                DataGridView1.Item(22, i2).Value = v3
                DataGridView1.Item(23, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 69.5) Then
                DataGridView1.Item(22, i2).Value = v4
                DataGridView1.Item(23, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 64.5) Then
                DataGridView1.Item(22, i2).Value = v5
                DataGridView1.Item(23, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 59.5) Then
                DataGridView1.Item(22, i2).Value = v6
                DataGridView1.Item(23, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 49.5) Then
                DataGridView1.Item(22, i2).Value = v7
                DataGridView1.Item(23, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 44.5) Then
                DataGridView1.Item(22, i2).Value = v8
                DataGridView1.Item(23, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 39.5) Then
                DataGridView1.Item(22, i2).Value = v9
                DataGridView1.Item(23, i2).Value = s9

            Else
                DataGridView1.Item(22, i2).Value = v10
                DataGridView1.Item(23, i2).Value = s10


            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub setgradep4mid()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(21, i2).Value = (Double.Parse(DataGridView1.Item(19, i2).Value))

            'DataGridView1.Item(21, i2).Value = (Double.Parse(DataGridView1.Item(18, i2).Value) + Double.Parse(DataGridView1.Item(19, i2).Value)) / 2



            If (Double.Parse(DataGridView1.Item(21, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 100) Then
                DataGridView1.Item(22, i2).Value = v1
                DataGridView1.Item(23, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 89.5) Then
                DataGridView1.Item(22, i2).Value = v2
                DataGridView1.Item(23, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 79.5) Then
                DataGridView1.Item(22, i2).Value = v3
                DataGridView1.Item(23, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 69.5) Then
                DataGridView1.Item(22, i2).Value = v4
                DataGridView1.Item(23, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 64.5) Then
                DataGridView1.Item(22, i2).Value = v5
                DataGridView1.Item(23, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 59.5) Then
                DataGridView1.Item(22, i2).Value = v6
                DataGridView1.Item(23, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 49.5) Then
                DataGridView1.Item(22, i2).Value = v7
                DataGridView1.Item(23, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 44.5) Then
                DataGridView1.Item(22, i2).Value = v8
                DataGridView1.Item(23, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 39.5) Then
                DataGridView1.Item(22, i2).Value = v9
                DataGridView1.Item(23, i2).Value = s9

            Else
                DataGridView1.Item(22, i2).Value = v10
                DataGridView1.Item(23, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub setgradep4midYESBOT()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index


            DataGridView1.Item(21, i2).Value = Double.Parse(DataGridView1.Item(18, i2).Value)



            If (Double.Parse(DataGridView1.Item(21, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 100) Then
                DataGridView1.Item(22, i2).Value = v1
                DataGridView1.Item(23, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 89.5) Then
                DataGridView1.Item(22, i2).Value = v2
                DataGridView1.Item(23, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 79.5) Then
                DataGridView1.Item(22, i2).Value = v3
                DataGridView1.Item(23, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 69.5) Then
                DataGridView1.Item(22, i2).Value = v4
                DataGridView1.Item(23, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 64.5) Then
                DataGridView1.Item(22, i2).Value = v5
                DataGridView1.Item(23, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 59.5) Then
                DataGridView1.Item(22, i2).Value = v6
                DataGridView1.Item(23, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 49.5) Then
                DataGridView1.Item(22, i2).Value = v7
                DataGridView1.Item(23, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 44.5) Then
                DataGridView1.Item(22, i2).Value = v8
                DataGridView1.Item(23, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(21, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(21, i2).Value) <= 39.5) Then
                DataGridView1.Item(22, i2).Value = v9
                DataGridView1.Item(23, i2).Value = s9

            Else
                DataGridView1.Item(22, i2).Value = v10
                DataGridView1.Item(23, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub checktoseeifmarksexists()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.aleveltotalpoints where class='" + txt_class.Text + "' and year='" + txt_year.Text + "' and term='" + txt_term.Text + "' and subject='" + txt_subject.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1

            End If


            If (count = 0) Then
                Checkexistingsubjects()
            ElseIf (count > 0) Then
                updatemarks()

            End If


            mycon.Close()


        Catch ex As Exception
            'MessageBox.Show(ex.Message)


        End Try


    End Sub
    Public Sub updatemarks()
        deletemarks()
        Checkexistingsubjects()

    End Sub



    Public Sub deletemarks()

        Try

            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from reportcards.aleveltotalpoints where class='" + txt_class.Text + "' and year='" + txt_year.Text + "' and term='" + txt_term.Text + "' and subject='" + txt_subject.Text + "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()

            myReader = SelectCommand.ExecuteReader()

            mycon.Close()


        Catch ex As Exception
            'MessageBox.Show(ex.Message)

        End Try
    End Sub



    Public Sub Checkexistingsubjects()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.aleveltotalpoints where subject='" & txt_subject.Text & "' and term='" & txt_term.Text & "' and year='" & txt_year.Text & "' and class='" + txt_class.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1

            End If

            If (count > 0) Then

                MessageBox.Show("You already uploaded your marks")

            ElseIf (count = 0) Then
                Savedata()

            End If



            mycon.Close()


        Catch ex As Exception
            'MessageBox.Show(ex.Message)


        End Try
    End Sub


    Public Sub Savedata()
        If (txt_subject.Text = "" And txt_level.Text = "") Then
            MessageBox.Show("Subject or level Missing")
        Else

            Try
                Dim i2 As Integer
                i2 = DataGridView1.CurrentRow.Index

                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
                    Dim con As New MySqlConnection(constring)
                    Dim cmd As New MySqlCommand("INSERT INTO reportcards.aleveltotalpoints(name,class,term,year,subject,Class_Teacher,date,password,initial,P1MID,P1END,AVGP1,GRADEP1,AGGREGATEP1,P2MID,P2END,AVGP2,GRADEP2,AGGREGATEP2,P3MID,P3END,AVGP3,GRADEP3,AGGREGATEP3,SCORE,REMARK,POINTS,enrtyid,P4MID,P4END,AVGP4,GRADEP4,AGGREGATEP4,P1BOT,P2BOT,P3BOT,P4BOT,code,P1,P2,P3,P4,ASSESSIMENT) VALUES(@name,@class,@term,@year,@subject,@ClassTeacher,@date,@password,@initial,@P1MID,@P1END,@AVGP1,@GRADEP1,@AGGREGATEP1,@P2MID,@P2END,@AVGP2,@GRADEP2,@AGGREGATEP2,@P3MID,@P3END,@AVGP3,@GRADEP3,@AGGREGATEP3,@SCORE,@REMARK,@POINTS,@enrtyid,@P4MID,@P4END,@AVGP4,@GRADEP4,@AGGREGATEP4,@P1BOT,@P2BOT,@P3BOT,@P4BOT,@code,@P1,@P2,@P3,@P4,@ASSESSIMENT)", con)
                    cmd.Parameters.AddWithValue("@name", row.Cells("NAME").Value)
                    cmd.Parameters.AddWithValue("@class", txt_class.Text)
                    cmd.Parameters.AddWithValue("@term", txt_term.Text)
                    cmd.Parameters.AddWithValue("@year", txt_year.Text)
                    cmd.Parameters.AddWithValue("@subject", txt_subject.Text)
                    cmd.Parameters.AddWithValue("@classteacher", txt_classteacher.Text)
                    cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                    cmd.Parameters.AddWithValue("@password", txt_password.Text)
                    cmd.Parameters.AddWithValue("@initial", txt_initial.Text)


                    cmd.Parameters.AddWithValue("@P1MID", row.Cells("P1MID").Value)
                    cmd.Parameters.AddWithValue("@P1END", row.Cells("P1END").Value)
                    cmd.Parameters.AddWithValue("@AVGP1", row.Cells("AVGP1").Value)

                    cmd.Parameters.AddWithValue("@GRADEP1", row.Cells("GRADEP1").Value)

                    cmd.Parameters.AddWithValue("@AGGREGATEP1", row.Cells("AGGREGATEP1").Value)
                    cmd.Parameters.AddWithValue("@P2MID", row.Cells("P2MID").Value)
                    cmd.Parameters.AddWithValue("@P2END", row.Cells("P2END").Value)
                    cmd.Parameters.AddWithValue("@AVGP2", row.Cells("AVGP2").Value)
                    cmd.Parameters.AddWithValue("@GRADEP2", row.Cells("GRADEP2").Value)
                    cmd.Parameters.AddWithValue("@AGGREGATEP2", row.Cells("AGGREGATEP2").Value)
                    cmd.Parameters.AddWithValue("@P3MID", row.Cells("P3MID").Value)
                    cmd.Parameters.AddWithValue("@P3END", row.Cells("P3END").Value)
                    cmd.Parameters.AddWithValue("@AVGP3", row.Cells("AVGP3").Value)
                    cmd.Parameters.AddWithValue("@GRADEP3", row.Cells("GRADEP3").Value)
                    cmd.Parameters.AddWithValue("@AGGREGATEP3", row.Cells("AGGREGATEP3").Value)
                    cmd.Parameters.AddWithValue("@SCORE", row.Cells("SCORE").Value)
                    cmd.Parameters.AddWithValue("@REMARK", row.Cells("REMARK").Value)
                    cmd.Parameters.AddWithValue("@POINTS", row.Cells("POINTS").Value)
                    cmd.Parameters.AddWithValue("@enrtyid", txt_entryid.Text)



                    cmd.Parameters.AddWithValue("@P4MID", row.Cells("P4MID").Value)
                    cmd.Parameters.AddWithValue("@P4END", row.Cells("P4END").Value)
                    cmd.Parameters.AddWithValue("@AVGP4", row.Cells("P4AVG").Value)
                    cmd.Parameters.AddWithValue("@GRADEP4", row.Cells("P4GRADE").Value)
                    cmd.Parameters.AddWithValue("@AGGREGATEP4", row.Cells("P4AGGREGATE").Value)

                    cmd.Parameters.AddWithValue("@P1BOT", row.Cells("P1BOT").Value)
                    cmd.Parameters.AddWithValue("@P2BOT", row.Cells("P2BOT").Value)
                    cmd.Parameters.AddWithValue("@P3BOT", row.Cells("P3BOT").Value)
                    cmd.Parameters.AddWithValue("@P4BOT", row.Cells("P4BOT").Value)
                    cmd.Parameters.AddWithValue("@code", txt_code.Text)
                    cmd.Parameters.AddWithValue("@P1", P1.Text)
                    cmd.Parameters.AddWithValue("@P2", P2.Text)
                    cmd.Parameters.AddWithValue("@P3", P3.Text)
                    cmd.Parameters.AddWithValue("@P4", P4.Text)
                    cmd.Parameters.AddWithValue("@ASSESSIMENT", txt_offersbot.Text)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                Next
                MessageBox.Show("Records Inserted.")

            Catch ex As Exception
                'MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Public Sub setRemarks()
        Dim i2 As Integer
        i2 = DataGridView1.CurrentRow.Index

        ' For Each row As DataGridViewRow In DataGridView1.Rows

        If (DataGridView1.Item(26, i2).Value = "6") Then

            DataGridView1.Item(25, i2).Value = "Good Attempt"

        ElseIf (DataGridView1.Item(26, i2).Value = "5") Then

            DataGridView1.Item(25, i2).Value = "Very Good"

        ElseIf (DataGridView1.Item(26, i2).Value = "4") Then

            DataGridView1.Item(25, i2).Value = "Good"

        ElseIf (DataGridView1.Item(26, i2).Value = "3") Then

            DataGridView1.Item(25, i2).Value = "Fair Good"

        ElseIf (DataGridView1.Item(26, i2).Value = "2") Then

            DataGridView1.Item(25, i2).Value = "Can Do Better"

        ElseIf (DataGridView1.Item(26, i2).Value = "1") Then

            DataGridView1.Item(25, i2).Value = "More Effort"

        ElseIf (DataGridView1.Item(26, i2).Value = "0") Then

            DataGridView1.Item(25, i2).Value = "More Effort"

        ElseIf (DataGridView1.Item(26, i2).Value = "0" And txt_subject.Text = "ICT") Then

            DataGridView1.Item(25, i2).Value = "More Effort"

        ElseIf (DataGridView1.Item(26, i2).Value = "1" And txt_subject.Text = "ICT") Then

            DataGridView1.Item(25, i2).Value = "Good Attempt"


        ElseIf (DataGridView1.Item(26, i2).Value = "1" And txt_subject.Text = "SUBMATH") Then

            DataGridView1.Item(25, i2).Value = "Good Attempt"


        ElseIf (DataGridView1.Item(26, i2).Value = "0" And txt_subject.Text = "SUBMATH") Then

            DataGridView1.Item(25, i2).Value = "More Effort"

        ElseIf (DataGridView1.Item(26, i2).Value = "1" And txt_subject.Text = "GP") Then

            DataGridView1.Item(25, i2).Value = "Good Attempt"

        ElseIf (DataGridView1.Item(26, i2).Value = "0" And txt_subject.Text = "GP") Then

            DataGridView1.Item(25, i2).Value = "More Effort"



        ElseIf (DataGridView1.Item(26, i2).Value = "0") Then

            DataGridView1.Item(25, i2).Value = "More Effort AND CONSULT TEACHERS"

        Else

        End If
        'Next
    End Sub
    Public Sub SubmathP2END()

        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(9, i2).Value = (Double.Parse(DataGridView1.Item(7, i2).Value) + Double.Parse(DataGridView1.Item(8, i2).Value)) / 2
            If (Double.Parse(DataGridView1.Item(9, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 100) Then
                DataGridView1.Item(8, i2).Value = ""
                DataGridView1.Item(9, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 89.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 79.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 69.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = ""

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 64.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 59.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 49.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 44.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 39.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            Else
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub SubmathP2MID()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index


            DataGridView1.Item(9, i2).Value = (Double.Parse(DataGridView1.Item(6, i2).Value) + Double.Parse(DataGridView1.Item(7, i2).Value)) / 2
            If (Double.Parse(DataGridView1.Item(9, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 100) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 89.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 79.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 69.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 64.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 59.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 49.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 44.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 39.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            Else
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub SubmathP1END()

        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(3, i2).Value = (Double.Parse(DataGridView1.Item(1, i2).Value) + Double.Parse(DataGridView1.Item(2, i2).Value)) / 2

            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 35.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            Else
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub SubmathP1MI()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(3, i2).Value = (Double.Parse(DataGridView1.Item(0, i2).Value) + Double.Parse(DataGridView1.Item(1, i2).Value)) / 2

            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            Else
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub setgradeICTANDSUBMTHP2MID()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(9, i2).Value = (Double.Parse(DataGridView1.Item(6, i2).Value) + Double.Parse(DataGridView1.Item(7, i2).Value)) / 2
            If (Double.Parse(DataGridView1.Item(9, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 100) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 89.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 79.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 69.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 64.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 59.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 49.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 44.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 39.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            Else
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub setgradeICTANDSUBMTHP2MIDANDEND()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index


            DataGridView1.Item(9, i2).Value = (Double.Parse(DataGridView1.Item(7, i2).Value) + Double.Parse(DataGridView1.Item(8, i2).Value)) / 2
            If (Double.Parse(DataGridView1.Item(9, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 100) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 89.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 79.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 69.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 64.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 59.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 49.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 44.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 39.5) Then
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            Else
                DataGridView1.Item(10, i2).Value = ""
                DataGridView1.Item(11, i2).Value = "0"

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub setgradeICTANDSUBMTHP1MIDANDEND()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(3, i2).Value = (Double.Parse(DataGridView1.Item(1, i2).Value) + Double.Parse(DataGridView1.Item(2, i2).Value)) / 2

            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            Else
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub setgradeGPMIDANDEND()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(3, i2).Value = (Double.Parse(DataGridView1.Item(1, i2).Value) + Double.Parse(DataGridView1.Item(2, i2).Value)) / 2

            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = v1
                DataGridView1.Item(5, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = v2
                DataGridView1.Item(5, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = v3
                DataGridView1.Item(5, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = v4
                DataGridView1.Item(5, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = v5
                DataGridView1.Item(5, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = v6
                DataGridView1.Item(5, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = v7
                DataGridView1.Item(5, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = v8
                DataGridView1.Item(5, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = v9
                DataGridView1.Item(5, i2).Value = s9

            Else
                DataGridView1.Item(4, i2).Value = v10
                DataGridView1.Item(5, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub setgradeICTANDSUBMTHP1MID()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(3, i2).Value = (Double.Parse(DataGridView1.Item(0, i2).Value) + Double.Parse(DataGridView1.Item(1, i2).Value)) / 2

            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "1"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            Else
                DataGridView1.Item(4, i2).Value = ""
                DataGridView1.Item(5, i2).Value = "0"

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub setgradeGPMID()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(3, i2).Value = (Double.Parse(DataGridView1.Item(0, i2).Value) + Double.Parse(DataGridView1.Item(1, i2).Value)) / 2

            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = v1
                DataGridView1.Item(5, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = v2
                DataGridView1.Item(5, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = v3
                DataGridView1.Item(5, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = v4
                DataGridView1.Item(5, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = v5
                DataGridView1.Item(5, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = v6
                DataGridView1.Item(5, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = v7
                DataGridView1.Item(5, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = v8
                DataGridView1.Item(5, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = v9
                DataGridView1.Item(5, i2).Value = s9

            Else
                DataGridView1.Item(4, i2).Value = v10
                DataGridView1.Item(5, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub setscore_and_remark()

        Dim i2 As Integer
        i2 = DataGridView1.CurrentRow.Index



        If (txt_subject.Text = "MATHEMATICS" Or txt_subject.Text = "ECONOMICS" Or txt_subject.Text = "HISTORY") Then


            If (DataGridView1.Item(5, i2).Value = 1 And DataGridView1.Item(11, i2).Value = 1) Then

                DataGridView1.Item(24, i2).Value = "A"
                DataGridView1.Item(26, i2).Value = "6"

            ElseIf (DataGridView1.Item(5, i2).Value = 1 And DataGridView1.Item(11, i2).Value = 2) Then

                DataGridView1.Item(24, i2).Value = "A"
                DataGridView1.Item(26, i2).Value = "6"


            ElseIf (DataGridView1.Item(5, i2).Value = 2 And DataGridView1.Item(11, i2).Value = 1) Then

                DataGridView1.Item(24, i2).Value = "A"
                DataGridView1.Item(26, i2).Value = "6"

            ElseIf (DataGridView1.Item(5, i2).Value = 2 And DataGridView1.Item(11, i2).Value = 2) Then

                DataGridView1.Item(24, i2).Value = "A"
                DataGridView1.Item(26, i2).Value = "6"

                'B

            ElseIf (DataGridView1.Item(5, i2).Value = 1 And DataGridView1.Item(11, i2).Value = 3) Then

                DataGridView1.Item(24, i2).Value = "B"
                DataGridView1.Item(26, i2).Value = "5"


            ElseIf (DataGridView1.Item(5, i2).Value = 3 And DataGridView1.Item(11, i2).Value = 1) Then

                DataGridView1.Item(24, i2).Value = "B"
                DataGridView1.Item(26, i2).Value = "5"

            ElseIf (DataGridView1.Item(5, i2).Value = 2 And DataGridView1.Item(11, i2).Value = 3) Then

                DataGridView1.Item(24, i2).Value = "B"
                DataGridView1.Item(26, i2).Value = "5"


            ElseIf (DataGridView1.Item(5, i2).Value = 3 And DataGridView1.Item(11, i2).Value = 2) Then

                DataGridView1.Item(24, i2).Value = "B"
                DataGridView1.Item(26, i2).Value = "5"


            ElseIf (DataGridView1.Item(5, i2).Value = 3 And DataGridView1.Item(11, i2).Value = 3) Then

                DataGridView1.Item(24, i2).Value = "B"
                DataGridView1.Item(26, i2).Value = "5"


                'C
            ElseIf (DataGridView1.Item(5, i2).Value = 1 And DataGridView1.Item(11, i2).Value = 4) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"

            ElseIf (DataGridView1.Item(5, i2).Value = 4 And DataGridView1.Item(11, i2).Value = 1) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"

            ElseIf (DataGridView1.Item(5, i2).Value = 2 And DataGridView1.Item(11, i2).Value = 4) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"

            ElseIf (DataGridView1.Item(5, i2).Value = 4 And DataGridView1.Item(11, i2).Value = 2) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"


            ElseIf (DataGridView1.Item(5, i2).Value = 3 And DataGridView1.Item(11, i2).Value = 4) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"


            ElseIf (DataGridView1.Item(5, i2).Value = 4 And DataGridView1.Item(11, i2).Value = 3) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"


            ElseIf (DataGridView1.Item(5, i2).Value = 4 And DataGridView1.Item(11, i2).Value = 4) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"


                'D
            ElseIf (DataGridView1.Item(5, i2).Value = 1 And DataGridView1.Item(11, i2).Value = 5) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

            ElseIf (DataGridView1.Item(5, i2).Value = 2 And DataGridView1.Item(11, i2).Value = 5) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

            ElseIf (DataGridView1.Item(5, i2).Value = 5 And DataGridView1.Item(11, i2).Value = 2) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

            ElseIf (DataGridView1.Item(5, i2).Value = 3 And DataGridView1.Item(11, i2).Value = 5) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

            ElseIf (DataGridView1.Item(5, i2).Value = 5 And DataGridView1.Item(11, i2).Value = 3) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

            ElseIf (DataGridView1.Item(5, i2).Value = 4 And DataGridView1.Item(11, i2).Value = 5) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"


            ElseIf (DataGridView1.Item(5, i2).Value = 5 And DataGridView1.Item(11, i2).Value = 4) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"


            ElseIf (DataGridView1.Item(5, i2).Value = 5 And DataGridView1.Item(11, i2).Value = 5) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

            ElseIf (DataGridView1.Item(5, i2).Value = 6 And DataGridView1.Item(11, i2).Value = 4) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

            ElseIf (DataGridView1.Item(5, i2).Value = 4 And DataGridView1.Item(11, i2).Value = 6) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

                'E


            ElseIf (DataGridView1.Item(5, i2).Value = 1 And DataGridView1.Item(11, i2).Value = 6) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 6 And DataGridView1.Item(11, i2).Value = 1) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 2 And DataGridView1.Item(11, i2).Value = 6) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 6 And DataGridView1.Item(11, i2).Value = 2) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 6 And DataGridView1.Item(11, i2).Value = 3) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 3 And DataGridView1.Item(11, i2).Value = 6) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 6 And DataGridView1.Item(11, i2).Value = 4) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 4 And DataGridView1.Item(11, i2).Value = 6) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 5 And DataGridView1.Item(11, i2).Value = 6) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 6 And DataGridView1.Item(11, i2).Value = 5) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"


            ElseIf (DataGridView1.Item(5, i2).Value = 6 And DataGridView1.Item(11, i2).Value = 6) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"


            ElseIf (DataGridView1.Item(5, i2).Value = 6 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 6) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 5) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 5 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 1 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 1) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"
            ElseIf (DataGridView1.Item(5, i2).Value = 2 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 2) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"
            ElseIf (DataGridView1.Item(5, i2).Value = 3 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 3) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"
                'O

            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 4) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 4 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value = 1 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 1) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 8 And DataGridView1.Item(11, i2).Value = 1) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 1 And DataGridView1.Item(11, i2).Value = 8) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value = 2 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 2) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 8 And DataGridView1.Item(11, i2).Value = 2) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 2 And DataGridView1.Item(11, i2).Value = 8) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"



            ElseIf (DataGridView1.Item(5, i2).Value = 3 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 3) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 8 And DataGridView1.Item(11, i2).Value = 3) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 3 And DataGridView1.Item(11, i2).Value = 8) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value = 4 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 4) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 8 And DataGridView1.Item(11, i2).Value = 4) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 4 And DataGridView1.Item(11, i2).Value = 8) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"



            ElseIf (DataGridView1.Item(5, i2).Value = 5 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 5) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 8 And DataGridView1.Item(11, i2).Value = 5) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 5 And DataGridView1.Item(11, i2).Value = 8) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value = 6 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 6) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 8 And DataGridView1.Item(11, i2).Value = 6) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 6 And DataGridView1.Item(11, i2).Value = 8) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 7 And DataGridView1.Item(11, i2).Value = 8) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value = 8 And DataGridView1.Item(11, i2).Value = 7) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value = 8 And DataGridView1.Item(11, i2).Value = 8) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"
                'F
            ElseIf (DataGridView1.Item(5, i2).Value = 8 And DataGridView1.Item(11, i2).Value = 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

            ElseIf (DataGridView1.Item(5, i2).Value = 9 And DataGridView1.Item(11, i2).Value = 8) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"



            ElseIf (DataGridView1.Item(5, i2).Value = 9 And DataGridView1.Item(11, i2).Value < 7) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value < 7 And DataGridView1.Item(11, i2).Value = 9) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value = "-" And DataGridView1.Item(11, i2).Value >= 0) Then

                DataGridView1.Item(24, i2).Value = "-"
                DataGridView1.Item(26, i2).Value = "-"
            ElseIf (DataGridView1.Item(5, i2).Value >= 0 And DataGridView1.Item(11, i2).Value = "-") Then

                DataGridView1.Item(24, i2).Value = "-"
                DataGridView1.Item(26, i2).Value = "-"

            ElseIf (DataGridView1.Item(5, i2).Value = 9 And DataGridView1.Item(11, i2).Value < 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"
            ElseIf (DataGridView1.Item(5, i2).Value < 9 And DataGridView1.Item(11, i2).Value = 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"
            ElseIf (DataGridView1.Item(5, i2).Value = 9 And DataGridView1.Item(11, i2).Value = 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

            End If

            ' Next


            'three papers
        ElseIf (txt_subject.Text = "LITERATURE" Or txt_subject.Text = "ENTREPRENUERSHIP" Or txt_subject.Text = "PHYSICS" Or txt_subject.Text = "CHEMISTRY" Or txt_subject.Text = "BIOLOGY" Or txt_subject.Text = "AGRICULTURE" Or txt_subject.Text = "GEOGRAPHY" Or txt_subject.Text = "SWAHILI" Or txt_subject.Text = "LUGANDA" Or txt_subject.Text = "DIVINITY" Or txt_subject.Text = "ARABIC" Or txt_subject.Text = "ISLAM" Or txt_subject.Text = "TECHNICAL DRAWING") Then


            'For Each row As DataGridViewRow In DataGridView1.Rows
            'A
            If (DataGridView1.Item(5, i2).Value <= 3 And DataGridView1.Item(11, i2).Value < 3 And DataGridView1.Item(17, i2).Value < 3) Then

                DataGridView1.Item(24, i2).Value = "A"
                DataGridView1.Item(26, i2).Value = "6"

            ElseIf (DataGridView1.Item(5, i2).Value < 3 And DataGridView1.Item(11, i2).Value <= 3 And DataGridView1.Item(17, i2).Value < 3) Then

                DataGridView1.Item(24, i2).Value = "A"
                DataGridView1.Item(26, i2).Value = "6"

            ElseIf (DataGridView1.Item(5, i2).Value < 3 And DataGridView1.Item(11, i2).Value < 3 And DataGridView1.Item(17, i2).Value <= 3) Then

                DataGridView1.Item(24, i2).Value = "A"
                DataGridView1.Item(26, i2).Value = "6"

                'B
            ElseIf (DataGridView1.Item(5, i2).Value <= 4 And DataGridView1.Item(11, i2).Value < 4 And DataGridView1.Item(17, i2).Value < 4) Then

                DataGridView1.Item(24, i2).Value = "B"
                DataGridView1.Item(26, i2).Value = "5"

            ElseIf (DataGridView1.Item(5, i2).Value < 4 And DataGridView1.Item(11, i2).Value <= 4 And DataGridView1.Item(17, i2).Value < 4) Then

                DataGridView1.Item(24, i2).Value = "B"
                DataGridView1.Item(26, i2).Value = "5"

            ElseIf (DataGridView1.Item(5, i2).Value < 4 And DataGridView1.Item(11, i2).Value < 4 And DataGridView1.Item(17, i2).Value <= 4) Then

                DataGridView1.Item(24, i2).Value = "B"
                DataGridView1.Item(26, i2).Value = "5"

                'C

            ElseIf (DataGridView1.Item(5, i2).Value <= 5 And DataGridView1.Item(11, i2).Value < 5 And DataGridView1.Item(17, i2).Value < 5) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"

            ElseIf (DataGridView1.Item(5, i2).Value < 5 And DataGridView1.Item(11, i2).Value <= 5 And DataGridView1.Item(17, i2).Value < 5) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"

            ElseIf (DataGridView1.Item(5, i2).Value < 5 And DataGridView1.Item(11, i2).Value < 5 And DataGridView1.Item(17, i2).Value <= 5) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"

                'D

            ElseIf (DataGridView1.Item(5, i2).Value <= 6 And DataGridView1.Item(11, i2).Value < 6 And DataGridView1.Item(17, i2).Value < 6) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

            ElseIf (DataGridView1.Item(5, i2).Value < 6 And DataGridView1.Item(11, i2).Value <= 6 And DataGridView1.Item(17, i2).Value < 6) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

            ElseIf (DataGridView1.Item(5, i2).Value < 6 And DataGridView1.Item(11, i2).Value < 6 And DataGridView1.Item(17, i2).Value <= 6) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

                'E

            ElseIf (DataGridView1.Item(5, i2).Value <= 7 And DataGridView1.Item(11, i2).Value < 7 And DataGridView1.Item(17, i2).Value < 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value < 7 And DataGridView1.Item(11, i2).Value <= 7 And DataGridView1.Item(17, i2).Value < 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value < 7 And DataGridView1.Item(11, i2).Value < 7 And DataGridView1.Item(17, i2).Value <= 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"


                'P8

            ElseIf (DataGridView1.Item(5, i2).Value <= 8 And DataGridView1.Item(11, i2).Value < 8 And DataGridView1.Item(17, i2).Value < 8) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value < 8 And DataGridView1.Item(11, i2).Value <= 8 And DataGridView1.Item(17, i2).Value < 8) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value < 8 And DataGridView1.Item(11, i2).Value < 8 And DataGridView1.Item(17, i2).Value <= 8) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"


                'O


            ElseIf (DataGridView1.Item(5, i2).Value = 9 And DataGridView1.Item(11, i2).Value < 9 And DataGridView1.Item(17, i2).Value < 9) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value < 9 And DataGridView1.Item(11, i2).Value = 9 And DataGridView1.Item(17, i2).Value < 9) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value < 9 And DataGridView1.Item(11, i2).Value < 9 And DataGridView1.Item(17, i2).Value = 9) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

                'F

            ElseIf (DataGridView1.Item(5, i2).Value = 9 And DataGridView1.Item(11, i2).Value = 9 And DataGridView1.Item(17, i2).Value = 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

            ElseIf (DataGridView1.Item(5, i2).Value = 9 And DataGridView1.Item(11, i2).Value = 9 And DataGridView1.Item(17, i2).Value < 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

            ElseIf (DataGridView1.Item(5, i2).Value < 9 And DataGridView1.Item(11, i2).Value = 9 And DataGridView1.Item(17, i2).Value = 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

            ElseIf (DataGridView1.Item(5, i2).Value = 9 And DataGridView1.Item(11, i2).Value < 9 And DataGridView1.Item(17, i2).Value = 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"


            End If
            'Next
            'three papers

        ElseIf (txt_subject.Text = "GP") Then

            'For Each row As DataGridViewRow In DataGridView1.Rows
            If (DataGridView1.Item(5, i2).Value < 7) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value > 6) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

            End If

            'Next

        ElseIf (txt_subject.Text = "ICT") Then

            'For Each row As DataGridViewRow In DataGridView1.Rows
            If (DataGridView1.Item(5, i2).Value < 7 And DataGridView1.Item(11, i2).Value < 7) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value > 6 Or DataGridView1.Item(11, i2).Value > 6) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

            End If

            'Next

        ElseIf (txt_subject.Text = "SUBMATH") Then

            'For Each row As DataGridViewRow In DataGridView1.Rows
            If (DataGridView1.Item(5, i2).Value < 7 And DataGridView1.Item(11, i2).Value < 7) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value > 6 Or DataGridView1.Item(11, i2).Value > 6) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

                ' End If

                'next
                'four papers like art

            End If ''''

            ' Next


            'four papers
        ElseIf (txt_subject.Text = "FINE ART" Or txt_subject.Text = "FRENCH") Then


            'For Each row As DataGridViewRow In DataGridView1.Rows
            'A
            If (DataGridView1.Item(5, i2).Value <= 3 And DataGridView1.Item(11, i2).Value < 3 And DataGridView1.Item(17, i2).Value < 3 And DataGridView1.Item(23, i2).Value < 3) Then

                DataGridView1.Item(24, i2).Value = "A"
                DataGridView1.Item(26, i2).Value = "6"

            ElseIf (DataGridView1.Item(5, i2).Value < 3 And DataGridView1.Item(11, i2).Value <= 3 And DataGridView1.Item(17, i2).Value < 3 And DataGridView1.Item(23, i2).Value < 3) Then

                DataGridView1.Item(24, i2).Value = "A"
                DataGridView1.Item(26, i2).Value = "6"

            ElseIf (DataGridView1.Item(5, i2).Value < 3 And DataGridView1.Item(11, i2).Value < 3 And DataGridView1.Item(23, i2).Value < 3 And DataGridView1.Item(17, i2).Value <= 3) Then

                DataGridView1.Item(24, i2).Value = "A"
                DataGridView1.Item(26, i2).Value = "6"

            ElseIf (DataGridView1.Item(5, i2).Value < 3 And DataGridView1.Item(11, i2).Value < 3 And DataGridView1.Item(23, i2).Value <= 3 And DataGridView1.Item(17, i2).Value < 3) Then

                DataGridView1.Item(24, i2).Value = "A"
                DataGridView1.Item(26, i2).Value = "6"

                'B
            ElseIf (DataGridView1.Item(5, i2).Value <= 4 And DataGridView1.Item(11, i2).Value < 4 And DataGridView1.Item(17, i2).Value < 4 And DataGridView1.Item(23, i2).Value < 4) Then

                DataGridView1.Item(24, i2).Value = "B"
                DataGridView1.Item(26, i2).Value = "5"

            ElseIf (DataGridView1.Item(5, i2).Value < 4 And DataGridView1.Item(11, i2).Value <= 4 And DataGridView1.Item(17, i2).Value < 4 And DataGridView1.Item(23, i2).Value < 4) Then

                DataGridView1.Item(24, i2).Value = "B"
                DataGridView1.Item(26, i2).Value = "5"

            ElseIf (DataGridView1.Item(5, i2).Value < 4 And DataGridView1.Item(11, i2).Value < 4 And DataGridView1.Item(17, i2).Value < 4 And DataGridView1.Item(23, i2).Value <= 4) Then

                DataGridView1.Item(24, i2).Value = "B"
                DataGridView1.Item(26, i2).Value = "5"

                'C

            ElseIf (DataGridView1.Item(5, i2).Value <= 5 And DataGridView1.Item(11, i2).Value < 5 And DataGridView1.Item(17, i2).Value < 5 And DataGridView1.Item(23, i2).Value < 5) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"

            ElseIf (DataGridView1.Item(5, i2).Value < 5 And DataGridView1.Item(11, i2).Value <= 5 And DataGridView1.Item(17, i2).Value < 5 And DataGridView1.Item(23, i2).Value < 5) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"

            ElseIf (DataGridView1.Item(5, i2).Value < 5 And DataGridView1.Item(11, i2).Value < 5 And DataGridView1.Item(17, i2).Value <= 5 And DataGridView1.Item(23, i2).Value < 5) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"

            ElseIf (DataGridView1.Item(5, i2).Value < 5 And DataGridView1.Item(11, i2).Value < 5 And DataGridView1.Item(17, i2).Value < 5 And DataGridView1.Item(23, i2).Value <= 5) Then

                DataGridView1.Item(24, i2).Value = "C"
                DataGridView1.Item(26, i2).Value = "4"

                'D

            ElseIf (DataGridView1.Item(5, i2).Value <= 6 And DataGridView1.Item(11, i2).Value < 6 And DataGridView1.Item(17, i2).Value < 6 And DataGridView1.Item(23, i2).Value < 6) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

            ElseIf (DataGridView1.Item(5, i2).Value < 6 And DataGridView1.Item(11, i2).Value <= 6 And DataGridView1.Item(17, i2).Value < 6 And DataGridView1.Item(23, i2).Value < 6) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

            ElseIf (DataGridView1.Item(5, i2).Value < 6 And DataGridView1.Item(11, i2).Value < 6 And DataGridView1.Item(17, i2).Value <= 6 And DataGridView1.Item(23, i2).Value < 6) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

            ElseIf (DataGridView1.Item(5, i2).Value < 6 And DataGridView1.Item(11, i2).Value < 6 And DataGridView1.Item(17, i2).Value < 6 And DataGridView1.Item(23, i2).Value <= 6) Then

                DataGridView1.Item(24, i2).Value = "D"
                DataGridView1.Item(26, i2).Value = "3"

                'E

            ElseIf (DataGridView1.Item(5, i2).Value <= 7 And DataGridView1.Item(11, i2).Value < 7 And DataGridView1.Item(17, i2).Value < 7 And DataGridView1.Item(23, i2).Value < 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value < 7 And DataGridView1.Item(11, i2).Value <= 7 And DataGridView1.Item(17, i2).Value < 7 And DataGridView1.Item(23, i2).Value < 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value < 7 And DataGridView1.Item(11, i2).Value < 7 And DataGridView1.Item(17, i2).Value < 7 And DataGridView1.Item(23, i2).Value <= 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value < 7 And DataGridView1.Item(11, i2).Value < 7 And DataGridView1.Item(17, i2).Value <= 7 And DataGridView1.Item(23, i2).Value < 7) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"


                'P8

            ElseIf (DataGridView1.Item(5, i2).Value <= 8 And DataGridView1.Item(11, i2).Value < 8 And DataGridView1.Item(17, i2).Value < 8 And DataGridView1.Item(23, i2).Value < 8) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value < 8 And DataGridView1.Item(11, i2).Value <= 8 And DataGridView1.Item(17, i2).Value < 8 And DataGridView1.Item(23, i2).Value < 8) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

            ElseIf (DataGridView1.Item(5, i2).Value < 8 And DataGridView1.Item(11, i2).Value < 8 And DataGridView1.Item(17, i2).Value <= 8 And DataGridView1.Item(23, i2).Value < 8) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"
            ElseIf (DataGridView1.Item(5, i2).Value < 8 And DataGridView1.Item(11, i2).Value < 8 And DataGridView1.Item(17, i2).Value < 8 And DataGridView1.Item(23, i2).Value <= 8) Then

                DataGridView1.Item(24, i2).Value = "E"
                DataGridView1.Item(26, i2).Value = "2"

                'O


            ElseIf (DataGridView1.Item(5, i2).Value = 9 And DataGridView1.Item(11, i2).Value < 9 And DataGridView1.Item(17, i2).Value < 9 And DataGridView1.Item(23, i2).Value < 9) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value < 9 And DataGridView1.Item(11, i2).Value = 9 And DataGridView1.Item(17, i2).Value < 9 And DataGridView1.Item(23, i2).Value < 9) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"

            ElseIf (DataGridView1.Item(5, i2).Value < 9 And DataGridView1.Item(11, i2).Value < 9 And DataGridView1.Item(17, i2).Value = 9 And DataGridView1.Item(23, i2).Value < 9) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


            ElseIf (DataGridView1.Item(5, i2).Value < 9 And DataGridView1.Item(11, i2).Value < 9 And DataGridView1.Item(17, i2).Value < 9 And DataGridView1.Item(23, i2).Value = 9) Then

                DataGridView1.Item(24, i2).Value = "O"
                DataGridView1.Item(26, i2).Value = "1"


                'F

            ElseIf (DataGridView1.Item(5, i2).Value = 9 And DataGridView1.Item(11, i2).Value = 9 And DataGridView1.Item(17, i2).Value = 9 And DataGridView1.Item(23, i2).Value = 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

            ElseIf (DataGridView1.Item(5, i2).Value = 9 And DataGridView1.Item(11, i2).Value = 9 And DataGridView1.Item(17, i2).Value < 9 And DataGridView1.Item(23, i2).Value < 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

            ElseIf (DataGridView1.Item(5, i2).Value < 9 And DataGridView1.Item(11, i2).Value = 9 And DataGridView1.Item(17, i2).Value = 9 And DataGridView1.Item(23, i2).Value < 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

            ElseIf (DataGridView1.Item(5, i2).Value = 9 And DataGridView1.Item(11, i2).Value < 9 And DataGridView1.Item(17, i2).Value = 9 And DataGridView1.Item(23, i2).Value < 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

            ElseIf (DataGridView1.Item(5, i2).Value < 9 And DataGridView1.Item(11, i2).Value < 9 And DataGridView1.Item(17, i2).Value < 9 And DataGridView1.Item(23, i2).Value = 9) Then

                DataGridView1.Item(24, i2).Value = "F"
                DataGridView1.Item(26, i2).Value = "0"

            End If

            'end four papers

        End If

    End Sub
    Public Sub setgradep3mid()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(15, i2).Value = (Double.Parse(DataGridView1.Item(13, i2).Value))
            'DataGridView1.Item(15, i2).Value = (Double.Parse(DataGridView1.Item(12, i2).Value) + Double.Parse(DataGridView1.Item(13, i2).Value)) / 2

            If (Double.Parse(DataGridView1.Item(15, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 100) Then
                DataGridView1.Item(16, i2).Value = v1
                DataGridView1.Item(17, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 89.5) Then
                DataGridView1.Item(16, i2).Value = v2
                DataGridView1.Item(17, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 79.5) Then
                DataGridView1.Item(16, i2).Value = v3
                DataGridView1.Item(17, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 69.5) Then
                DataGridView1.Item(16, i2).Value = v4
                DataGridView1.Item(17, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 64.5) Then
                DataGridView1.Item(16, i2).Value = v5
                DataGridView1.Item(17, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 59.5) Then
                DataGridView1.Item(16, i2).Value = v6
                DataGridView1.Item(17, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 49.5) Then
                DataGridView1.Item(16, i2).Value = v7
                DataGridView1.Item(17, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 44.5) Then
                DataGridView1.Item(16, i2).Value = v8
                DataGridView1.Item(17, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 39.5) Then
                DataGridView1.Item(16, i2).Value = v9
                DataGridView1.Item(17, i2).Value = s9

            Else
                DataGridView1.Item(16, i2).Value = v10
                DataGridView1.Item(17, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub setgradep3midYESBOT()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(15, i2).Value = Double.Parse(DataGridView1.Item(12, i2).Value)

            If (Double.Parse(DataGridView1.Item(15, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 100) Then
                DataGridView1.Item(16, i2).Value = v1
                DataGridView1.Item(17, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 89.5) Then
                DataGridView1.Item(16, i2).Value = v2
                DataGridView1.Item(17, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 79.5) Then
                DataGridView1.Item(16, i2).Value = v3
                DataGridView1.Item(17, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 69.5) Then
                DataGridView1.Item(16, i2).Value = v4
                DataGridView1.Item(17, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 64.5) Then
                DataGridView1.Item(16, i2).Value = v5
                DataGridView1.Item(17, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 59.5) Then
                DataGridView1.Item(16, i2).Value = v6
                DataGridView1.Item(17, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 49.5) Then
                DataGridView1.Item(16, i2).Value = v7
                DataGridView1.Item(17, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 44.5) Then
                DataGridView1.Item(16, i2).Value = v8
                DataGridView1.Item(17, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 39.5) Then
                DataGridView1.Item(16, i2).Value = v9
                DataGridView1.Item(17, i2).Value = s9

            Else
                DataGridView1.Item(16, i2).Value = v10
                DataGridView1.Item(17, i2).Value = s10
            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub setgradep3midNOBOT()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(15, i2).Value = Double.Parse(DataGridView1.Item(13, i2).Value)

            If (Double.Parse(DataGridView1.Item(15, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 100) Then
                DataGridView1.Item(16, i2).Value = v1
                DataGridView1.Item(17, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 89.5) Then
                DataGridView1.Item(16, i2).Value = v2
                DataGridView1.Item(17, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 79.5) Then
                DataGridView1.Item(16, i2).Value = v3
                DataGridView1.Item(17, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 69.5) Then
                DataGridView1.Item(16, i2).Value = v4
                DataGridView1.Item(17, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 64.5) Then
                DataGridView1.Item(16, i2).Value = v5
                DataGridView1.Item(17, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 59.5) Then
                DataGridView1.Item(16, i2).Value = v6
                DataGridView1.Item(17, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 49.5) Then
                DataGridView1.Item(16, i2).Value = v7
                DataGridView1.Item(17, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 44.5) Then
                DataGridView1.Item(16, i2).Value = v8
                DataGridView1.Item(17, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 39.5) Then
                DataGridView1.Item(16, i2).Value = v9
                DataGridView1.Item(17, i2).Value = s9

            Else
                DataGridView1.Item(16, i2).Value = v10
                DataGridView1.Item(17, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub setgradep2mid()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(9, i2).Value = (Double.Parse(DataGridView1.Item(7, i2).Value))
            'DataGridView1.Item(9, i2).Value = (Double.Parse(DataGridView1.Item(6, i2).Value) + Double.Parse(DataGridView1.Item(7, i2).Value)) / 2
            If (Double.Parse(DataGridView1.Item(9, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 100) Then
                DataGridView1.Item(10, i2).Value = v1
                DataGridView1.Item(11, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 89.5) Then
                DataGridView1.Item(10, i2).Value = v2
                DataGridView1.Item(11, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 79.5) Then
                DataGridView1.Item(10, i2).Value = v3
                DataGridView1.Item(11, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 69.5) Then
                DataGridView1.Item(10, i2).Value = v4
                DataGridView1.Item(11, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 64.5) Then
                DataGridView1.Item(10, i2).Value = v5
                DataGridView1.Item(11, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 59.5) Then
                DataGridView1.Item(10, i2).Value = v6
                DataGridView1.Item(11, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 49.5) Then
                DataGridView1.Item(10, i2).Value = v7
                DataGridView1.Item(11, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 44.5) Then
                DataGridView1.Item(10, i2).Value = v8
                DataGridView1.Item(11, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 39.5) Then
                DataGridView1.Item(10, i2).Value = v9
                DataGridView1.Item(11, i2).Value = s9

            Else
                DataGridView1.Item(10, i2).Value = v10
                DataGridView1.Item(11, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub setgradep2midYESBOT()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(9, i2).Value = Double.Parse(DataGridView1.Item(6, i2).Value)
            If (Double.Parse(DataGridView1.Item(9, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 100) Then
                DataGridView1.Item(10, i2).Value = v1
                DataGridView1.Item(11, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 89.5) Then
                DataGridView1.Item(10, i2).Value = v2
                DataGridView1.Item(11, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 79.5) Then
                DataGridView1.Item(10, i2).Value = v3
                DataGridView1.Item(11, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 69.5) Then
                DataGridView1.Item(10, i2).Value = v4
                DataGridView1.Item(11, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 64.5) Then
                DataGridView1.Item(10, i2).Value = v5
                DataGridView1.Item(11, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 59.5) Then
                DataGridView1.Item(10, i2).Value = v6
                DataGridView1.Item(11, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 49.5) Then
                DataGridView1.Item(10, i2).Value = v7
                DataGridView1.Item(11, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 44.5) Then
                DataGridView1.Item(10, i2).Value = v8
                DataGridView1.Item(11, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 39.5) Then
                DataGridView1.Item(10, i2).Value = v9
                DataGridView1.Item(11, i2).Value = s9

            Else
                DataGridView1.Item(10, i2).Value = v10
                DataGridView1.Item(11, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub setgradep2midNOBOT()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(9, i2).Value = Double.Parse(DataGridView1.Item(7, i2).Value)
            If (Double.Parse(DataGridView1.Item(9, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 100) Then
                DataGridView1.Item(10, i2).Value = v1
                DataGridView1.Item(11, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 89.5) Then
                DataGridView1.Item(10, i2).Value = v2
                DataGridView1.Item(11, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 79.5) Then
                DataGridView1.Item(10, i2).Value = v3
                DataGridView1.Item(11, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 69.5) Then
                DataGridView1.Item(10, i2).Value = v4
                DataGridView1.Item(11, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 64.5) Then
                DataGridView1.Item(10, i2).Value = v5
                DataGridView1.Item(11, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 59.5) Then
                DataGridView1.Item(10, i2).Value = v6
                DataGridView1.Item(11, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 49.5) Then
                DataGridView1.Item(10, i2).Value = v7
                DataGridView1.Item(11, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 44.5) Then
                DataGridView1.Item(10, i2).Value = v8
                DataGridView1.Item(11, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 39.5) Then
                DataGridView1.Item(10, i2).Value = v9
                DataGridView1.Item(11, i2).Value = s9

            Else
                DataGridView1.Item(10, i2).Value = v10
                DataGridView1.Item(11, i2).Value = s10


            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    '
    Public Sub setgradep1mid()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            DataGridView1.Item(3, i2).Value = (Double.Parse(DataGridView1.Item(1, i2).Value))
            ' DataGridView1.Item(3, i2).Value = (Double.Parse(DataGridView1.Item(0, i2).Value) + Double.Parse(DataGridView1.Item(1, i2).Value)) / 2

            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = v1
                DataGridView1.Item(5, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = v2
                DataGridView1.Item(5, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = v3
                DataGridView1.Item(5, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = v4
                DataGridView1.Item(5, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = v5
                DataGridView1.Item(5, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = v6
                DataGridView1.Item(5, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = v7
                DataGridView1.Item(5, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = v8
                DataGridView1.Item(5, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = v9
                DataGridView1.Item(5, i2).Value = s9

            Else
                DataGridView1.Item(4, i2).Value = v10
                DataGridView1.Item(5, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub setgradep1midYESBOT()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index


            DataGridView1.Item(3, i2).Value = Double.Parse(DataGridView1.Item(0, i2).Value)

            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = v1
                DataGridView1.Item(5, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = v2
                DataGridView1.Item(5, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = v3
                DataGridView1.Item(5, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = v4
                DataGridView1.Item(5, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = v5
                DataGridView1.Item(5, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = v6
                DataGridView1.Item(5, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = v7
                DataGridView1.Item(5, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = v8
                DataGridView1.Item(5, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = v9
                DataGridView1.Item(5, i2).Value = s9

            Else
                DataGridView1.Item(4, i2).Value = v10
                DataGridView1.Item(5, i2).Value = s10


            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub setgradep1midNOBOT()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index


            DataGridView1.Item(3, i2).Value = Double.Parse(DataGridView1.Item(1, i2).Value)

            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = v1
                DataGridView1.Item(5, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = v2
                DataGridView1.Item(5, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = v3
                DataGridView1.Item(5, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = v4
                DataGridView1.Item(5, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = v5
                DataGridView1.Item(5, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = v6
                DataGridView1.Item(5, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = v7
                DataGridView1.Item(5, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = v8
                DataGridView1.Item(5, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = v9
                DataGridView1.Item(5, i2).Value = s9

            Else
                DataGridView1.Item(4, i2).Value = v10
                DataGridView1.Item(5, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub setgradep3()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index


            DataGridView1.Item(15, i2).Value = (Double.Parse(DataGridView1.Item(13, i2).Value) + Double.Parse(DataGridView1.Item(14, i2).Value)) / 2



            If (Double.Parse(DataGridView1.Item(15, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 100) Then
                DataGridView1.Item(16, i2).Value = v1
                DataGridView1.Item(17, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 89.5) Then
                DataGridView1.Item(16, i2).Value = v2
                DataGridView1.Item(17, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 79.5) Then
                DataGridView1.Item(16, i2).Value = v3
                DataGridView1.Item(17, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 69.5) Then
                DataGridView1.Item(16, i2).Value = v4
                DataGridView1.Item(17, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 64.5) Then
                DataGridView1.Item(16, i2).Value = v5
                DataGridView1.Item(17, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 59.5) Then
                DataGridView1.Item(16, i2).Value = v6
                DataGridView1.Item(17, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 49.5) Then
                DataGridView1.Item(16, i2).Value = v7
                DataGridView1.Item(17, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 44.5) Then
                DataGridView1.Item(16, i2).Value = v8
                DataGridView1.Item(17, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(15, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(15, i2).Value) <= 39.5) Then
                DataGridView1.Item(16, i2).Value = v9
                DataGridView1.Item(17, i2).Value = s9

            Else
                DataGridView1.Item(16, i2).Value = v10
                DataGridView1.Item(17, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub setgradep2()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index


            DataGridView1.Item(9, i2).Value = (Double.Parse(DataGridView1.Item(7, i2).Value) + Double.Parse(DataGridView1.Item(8, i2).Value)) / 2
            If (Double.Parse(DataGridView1.Item(9, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 100) Then
                DataGridView1.Item(10, i2).Value = v1
                DataGridView1.Item(11, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 89.5) Then
                DataGridView1.Item(10, i2).Value = v2
                DataGridView1.Item(11, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 79.5) Then
                DataGridView1.Item(10, i2).Value = v3
                DataGridView1.Item(11, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 69.5) Then
                DataGridView1.Item(10, i2).Value = v4
                DataGridView1.Item(11, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 64.5) Then
                DataGridView1.Item(10, i2).Value = v5
                DataGridView1.Item(11, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 59.5) Then
                DataGridView1.Item(10, i2).Value = v6
                DataGridView1.Item(11, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 49.5) Then
                DataGridView1.Item(10, i2).Value = v7
                DataGridView1.Item(11, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 44.5) Then
                DataGridView1.Item(10, i2).Value = v8
                DataGridView1.Item(11, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(9, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(9, i2).Value) <= 39.5) Then
                DataGridView1.Item(10, i2).Value = v9
                DataGridView1.Item(11, i2).Value = s9

            Else
                DataGridView1.Item(10, i2).Value = v10
                DataGridView1.Item(11, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean

        Dim key As Keys = keyData And Keys.KeyCode

        If key = Keys.Enter Then
            MyBase.OnKeyDown(New KeyEventArgs(keyData))
            Return True
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
    End Function

    Private Sub DataGridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim ri As Integer = DataGridView1.CurrentCell.RowIndex
                Dim ci As Integer = DataGridView1.CurrentCell.ColumnIndex
                e.SuppressKeyPress = True
                FindNextCell(DataGridView1, ri, ci + 1)  'checking from Next  
            End If
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try

    End Sub

    Sub FindNextCell(ByVal dgv As DataGridView, ByVal rowindex As Integer, ByVal columnindex As Integer)
        Try
            Dim found As Boolean = False

            While dgv.RowCount > rowindex
                While dgv.Columns.Count > columnindex
                    If Not (dgv.Rows(rowindex).Cells(columnindex)).ReadOnly Then
                        dgv.CurrentCell = dgv.Rows(rowindex).Cells(columnindex)
                        Exit Sub
                    Else
                        columnindex += 1
                    End If
                End While
                rowindex += 1
                columnindex = 0
            End While

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub DataGridView1_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        Try
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)


            calculateaverage()

            setRemarks()
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        Try
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)


            calculateaverage()

            setRemarks()


        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub setgradep1()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index


            DataGridView1.Item(3, i2).Value = (Double.Parse(DataGridView1.Item(1, i2).Value) + Double.Parse(DataGridView1.Item(2, i2).Value)) / 2

            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = v1
                DataGridView1.Item(5, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = v2
                DataGridView1.Item(5, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = v3
                DataGridView1.Item(5, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = v4
                DataGridView1.Item(5, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = v5
                DataGridView1.Item(5, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = v6
                DataGridView1.Item(5, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = v7
                DataGridView1.Item(5, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = v8
                DataGridView1.Item(5, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = v9
                DataGridView1.Item(5, i2).Value = s9

            Else
                DataGridView1.Item(4, i2).Value = v10
                DataGridView1.Item(5, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub alevelgrading()

        setgradep1()
        setgradep2()
        setgradep3()
        setgradep4()

    End Sub
    Public Sub setgradeP13P()
        Try

            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index


            DataGridView1.Item(3, i2).Value = (Double.Parse(DataGridView1.Item(1, i2).Value) + Double.Parse(DataGridView1.Item(7, i2).Value) + Double.Parse(DataGridView1.Item(13, i2).Value)) / 3

            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = v1
                DataGridView1.Item(5, i2).Value = s1

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = v2
                DataGridView1.Item(5, i2).Value = s2

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = v3
                DataGridView1.Item(5, i2).Value = s3

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = v4
                DataGridView1.Item(5, i2).Value = s4

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = v5
                DataGridView1.Item(5, i2).Value = s5

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = v6
                DataGridView1.Item(5, i2).Value = s6

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = v7
                DataGridView1.Item(5, i2).Value = s7

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = v8
                DataGridView1.Item(5, i2).Value = s8

            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = v9
                DataGridView1.Item(5, i2).Value = s9

            Else
                DataGridView1.Item(4, i2).Value = v10
                DataGridView1.Item(5, i2).Value = s10

            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub calculateaverage()

        Dim i2 As Integer
        i2 = DataGridView1.CurrentRow.Index

        If (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "MID AND END") Then
            alevelgrading()
            'twops
            If (DataGridView1.Item(3, i2).Value >= 0) Then


                setscore_and_remark()
            End If
        ElseIf (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "CONTINOUS ASSESSEMENT") Then
            alevelgradingmid()
            'twops
            If (DataGridView1.Item(3, i2).Value >= 0) Then


                setscore_and_remark()
            End If


        ElseIf (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "MID") Then
            alevelgradingmid()

            'twops
            If (DataGridView1.Item(3, i2).Value >= 0) Then


                setscore_and_remark()
            End If


        ElseIf (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "MID AND CONTINOUS ASSESSEMENT") Then
            alevelgrading()
            'twops
            If (DataGridView1.Item(3, i2).Value >= 0) Then


                setscore_and_remark()
            End If


        ElseIf (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "PRE-MOCK") Then
            alevelgradingmid()
            'twops
            If (DataGridView1.Item(3, i2).Value >= 0) Then


                setscore_and_remark()
            End If


        ElseIf (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "MOCK") Then
            alevelgradingmid()
            'twops
            If (DataGridView1.Item(3, i2).Value >= 0) Then


                setscore_and_remark()
            End If


        ElseIf (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "PRE-REGISTRATION") Then
            alevelgradingmid()
            'twops
            If (DataGridView1.Item(3, i2).Value >= 0) Then


                setscore_and_remark()
            End If

        ElseIf (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "END") Then
            ' alevelgrading()
            'twops
            If (DataGridView1.Item(3, i2).Value >= 0) Then


                setscore_and_remark()
            End If


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''endof two papers
        ElseIf (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "FULL" And txt_subject.Text = "SUBMATH") Then
            setgradeICTANDSUBMTHP1MIDANDEND()
            setgradeICTANDSUBMTHP2MIDANDEND()

            If (DataGridView1.Item(3, i2).Value >= 0) Then


                setscore_and_remark()
            End If

        ElseIf (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "FULL" And txt_subject.Text = "GP") Then
            setgradeGPMIDANDEND()

            If (DataGridView1.Item(3, i2).Value >= 0) Then


                setscore_and_remark()
            End If

        ElseIf (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "FULL" And txt_subject.Text = "ICT") Then
            setgradeICTANDSUBMTHP1MIDANDEND()
            setgradeICTANDSUBMTHP2MIDANDEND()

            If (DataGridView1.Item(3, i2).Value >= 0) Then


                setscore_and_remark()
            End If


        End If

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''3papers
        If (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "MID" And (txt_subject.Text = "LITERATURE" Or txt_subject.Text = "ENTREPRENUERSHIP" Or txt_subject.Text = "PHYSICS" Or txt_subject.Text = "CHEMISTRY" Or txt_subject.Text = "BIOLOGY" Or txt_subject.Text = "AGRICULTURE" Or txt_subject.Text = "GEOGRAPHY" Or txt_subject.Text = "SWAHILI" Or txt_subject.Text = "LUGANDA" Or txt_subject.Text = "DIVINITY" Or txt_subject.Text = "ARABIC" Or txt_subject.Text = "ISLAM")) Then
            'setgradeP13P()
            setgradep1midNOBOT()
            setgradep2midNOBOT()
            setgradep3midNOBOT()

            If (DataGridView1.Item(3, i2).Value >= 0) Then
                setscore_and_remark()
            End If


        ElseIf (txt_level.Text = "A LEVEL" And txt_offersbot.Text = "END" And (txt_subject.Text = "LITERATURE" Or txt_subject.Text = "ENTREPRENUERSHIP" Or txt_subject.Text = "PHYSICS" Or txt_subject.Text = "CHEMISTRY" Or txt_subject.Text = "BIOLOGY" Or txt_subject.Text = "AGRICULTURE" Or txt_subject.Text = "GEOGRAPHY" Or txt_subject.Text = "SWAHILI" Or txt_subject.Text = "LUGANDA" Or txt_subject.Text = "DIVINITY" Or txt_subject.Text = "ARABIC" Or txt_subject.Text = "ISLAM")) Then
            'setgradeP13P()
            setgradep1midNOBOT()
            setgradep2midNOBOT()
            setgradep3midNOBOT()

            'ART AND FRENCH
       
            ''
            If (DataGridView1.Item(3, i2).Value >= 0) Then
                setscore_and_remark()
            End If

        End If
    End Sub
    Public Sub fill_classteachers()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.classes where class='" + txt_class.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim classteachers As String = myReader.GetString("Class_Teacher").ToString()


                txt_classteacher.Text = classteachers

            End While

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try


    End Sub
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
    Public Sub fill_name()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select name AS NAME from reportcards.students where class='" + txt_class.Text + "' and year='" + txt_year.Text + "' ORDER BY name asc ;", conDatabase)
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
            MessageBox.Show("Please Select Term and Year")

        End Try
    End Sub
    Public Sub alevelgradingmid()

        setgradep1mid()
        setgradep2mid()
        setgradep3mid()
        setgradep4mid()

    End Sub
    Public Sub setdefault()
        Try

            If (txt_report.Text = "FULL") Then


                Dim dgval As String = "-"
                Dim dgval1 As String = "0"
                For Each row As DataGridViewRow In DataGridView1.Rows

                    Dim i2 As Integer
                    i2 = DataGridView1.CurrentRow.Index

                    row.Cells("P1MID").Value = dgval

                    row.Cells("P1END").Value = dgval

                    row.Cells("AVGP1").Value = dgval
                    row.Cells("P2MID").Value = dgval
                    row.Cells("P2END").Value = dgval
                    row.Cells("AVGP2").Value = dgval

                    row.Cells("P1BOT").Value = dgval
                    row.Cells("P2BOT").Value = dgval
                    row.Cells("P3BOT").Value = dgval
                    row.Cells("P4BOT").Value = dgval
                    row.Cells("P4MID").Value = dgval
                    row.Cells("P4END").Value = dgval
                    row.Cells("P4AVG").Value = dgval
                    row.Cells("P4GRADE").Value = dgval

                    row.Cells("P3MID").Value = dgval

                    row.Cells("P3END").Value = dgval

                    row.Cells("AVGP3").Value = dgval
                    row.Cells("GRADEP1").Value = dgval
                    row.Cells("GRADEP2").Value = dgval
                    row.Cells("GRADEP3").Value = dgval
                    row.Cells("SCORE").Value = dgval
                    row.Cells("REMARK").Value = dgval
                    row.Cells("GRADEP3").Value = dgval
                    row.Cells("POINTS").Value = dgval

                    row.Cells("AGGREGATEP1").Value = 0
                    row.Cells("AGGREGATEP2").Value = 0
                    row.Cells("AGGREGATEP3").Value = 0


                    row.Cells("P4AGGREGATE").Value = 0
                   
                Next

            ElseIf (txt_report.Text = "MID") Then


                Dim dgval As String = "-"
                Dim dgval1 As String = "0"
                For Each row As DataGridViewRow In DataGridView1.Rows

                    Dim i2 As Integer
                    i2 = DataGridView1.CurrentRow.Index

                    row.Cells("P1MID").Value = dgval

                    row.Cells("P1END").Value = dgval

                    row.Cells("AVGP1").Value = dgval
                    row.Cells("P2MID").Value = dgval
                    row.Cells("P2END").Value = dgval
                    row.Cells("AVGP2").Value = dgval

                    row.Cells("P1BOT").Value = dgval
                    row.Cells("P2BOT").Value = dgval
                    row.Cells("P3BOT").Value = dgval
                    row.Cells("P4BOT").Value = dgval
                    row.Cells("P4MID").Value = dgval
                    row.Cells("P4END").Value = dgval
                    row.Cells("P4AVG").Value = dgval
                    row.Cells("P4GRADE").Value = dgval

                    row.Cells("P3MID").Value = dgval

                    row.Cells("P3END").Value = dgval

                    row.Cells("AVGP3").Value = dgval
                    row.Cells("GRADEP1").Value = dgval
                    row.Cells("GRADEP2").Value = dgval
                    row.Cells("GRADEP3").Value = dgval
                    row.Cells("SCORE").Value = dgval
                    row.Cells("REMARK").Value = dgval
                    row.Cells("GRADEP3").Value = dgval
                    row.Cells("POINTS").Value = dgval

                    row.Cells("AGGREGATEP1").Value = 0
                    row.Cells("AGGREGATEP2").Value = 0
                    row.Cells("AGGREGATEP3").Value = 0


                    row.Cells("P4AGGREGATE").Value = 0

                Next

            ElseIf (txt_report.Text = "BOT") Then


                Dim dgval As String = "-"
                Dim dgval1 As String = "0"
                For Each row As DataGridViewRow In DataGridView1.Rows

                    Dim i2 As Integer
                    i2 = DataGridView1.CurrentRow.Index

                    row.Cells("P1MID").Value = dgval

                    row.Cells("P1END").Value = dgval

                    row.Cells("AVGP1").Value = dgval
                    row.Cells("P2MID").Value = dgval
                    row.Cells("P2END").Value = dgval
                    row.Cells("AVGP2").Value = dgval

                    row.Cells("P1BOT").Value = dgval
                    row.Cells("P2BOT").Value = dgval
                    row.Cells("P3BOT").Value = dgval
                    row.Cells("P4BOT").Value = dgval
                    row.Cells("P4MID").Value = dgval
                    row.Cells("P4END").Value = dgval
                    row.Cells("P4AVG").Value = dgval
                    row.Cells("P4GRADE").Value = dgval

                    row.Cells("P3MID").Value = dgval

                    row.Cells("P3END").Value = dgval

                    row.Cells("AVGP3").Value = dgval
                    row.Cells("GRADEP1").Value = dgval
                    row.Cells("GRADEP2").Value = dgval
                    row.Cells("GRADEP3").Value = dgval
                    row.Cells("SCORE").Value = dgval
                    row.Cells("REMARK").Value = dgval
                    row.Cells("GRADEP3").Value = dgval
                    row.Cells("POINTS").Value = dgval

                    row.Cells("AGGREGATEP1").Value = 0
                    row.Cells("AGGREGATEP2").Value = 0
                    row.Cells("AGGREGATEP3").Value = 0


                    row.Cells("P4AGGREGATE").Value = 0

                Next


            End If

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub txt_class_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_class.SelectedIndexChanged
        Try
            fill_name()

            fill_classteachers()
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
        setdefault()
    End Sub

    Private Sub txt_year_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_year.SelectedIndexChanged
        Try
            fill_name()
            fill_classteachers()
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
        setdefault()
    End Sub
    Public Sub getmaxid()

        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select max(id) from reportcards.aleveltotalpoints ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            If (myReader.Read()) Then
                maxid = myReader.GetString("max(id)")
                entryid = "E" & maxid
                txt_entryid.Text = entryid
            End If

            mycon.Close()


        Catch ex As Exception
            'MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub fill_grid2()

        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select P1MID,P1END,AVGP1,GRADEP1,AGGREGATEP1,P2MID,P2END,AVGP2,GRADEP2,AGGREGATEP2,P3MID,P3END,AVGP3,GRADEP3,AGGREGATEP3,SCORE,REMARK,POINTS,NAME,id from reportcards.aleveltotalpoints where subject='" + Me.txt_subject.Text + "' and class='" + Me.txt_class.Text + "' and year='" + Me.txt_year.Text + "';", conDatabase)
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


    Private Sub RecordMarksALevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fill_classes()
            fillsub()
            getmaxid()
            txt_level.Text = "A LEVEL"

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub fillsub()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.subjecta", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim subject As String = myReader.GetString("subject").ToString()

                txt_subject.Items.Add(subject)


            End While

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub fill_subjects()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.teachers where password='" + txt_password.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            If (myReader.Read()) Then
                Dim subject As String = myReader.GetString("subject").ToString()
                Dim initial As String = myReader.GetString("initial").ToString()
                txt_subject.Text = subject
                txt_initial.Text = initial

            Else
                MessageBox.Show("Re-Enter Password & Try Again")
            End If

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Try
            fill_subjects()
            
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub txt_level_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_level.SelectedIndexChanged
        If (txt_level.Text.Length > 0 And txt_report.Text.Length > 0) Then
            DataGridView1.Enabled = True
        Else

        End If
    End Sub

    Private Sub txt_report_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_report.SelectedIndexChanged
        If (txt_level.Text.Length > 0 And txt_report.Text.Length > 0) Then
            DataGridView1.Enabled = True
            setdefault()
        Else

        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
            MessageBox.Show("Please you must fill the class , term , year , subject  to continue")
        Else
            checktoseeifmarksexists()

        End If
    End Sub

    Private Sub AlevelClassReportsArtsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ALEVELSINGLESTUDENTSARTSREPORT.Show()
    End Sub
    Public Sub fetchexistingmarks()

        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("SELECT  P1BOT,P1MID,P1END,AVGP1,GRADEP1,AGGREGATEP1,P2BOT,P2MID,P2END,AVGP2,GRADEP2,AGGREGATEP2,P3BOT,P3MID,P3END,AVGP3,GRADEP3,AGGREGATEP3,P4BOT,P4MID AS P4MID,P4END AS P4END,AVGP4 AS P4AVG,GRADEP4 AS P4GRADE,AGGREGATEP4 AS P4AGGREGATE,SCORE,REMARK,POINTS,NAME  FROM reportcards.aleveltotalpoints where name in (SELECT distinct name from reportcards.aleveltotalpoints) and class='" + txt_class.Text + "' and year='" + txt_year.Text + "' and term='" + txt_term.Text + "' and subject='" + txt_subject.Text + "' GROUP BY name ;", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            DataGridView1.DataSource = bSource

            sda.Update(dbDataset)
            conDatabase.Close()

            Dim dgval As String = "-"
            Dim dgval1 As String = "0"
            For Each row As DataGridViewRow In DataGridView1.Rows

                Dim i2 As Integer
                i2 = DataGridView1.CurrentRow.Index

                DataGridView1.Columns(0).Visible = False
                DataGridView1.Columns(3).Visible = False
                DataGridView1.Columns(5).Visible = False

                DataGridView1.Columns(6).Visible = False
                DataGridView1.Columns(9).Visible = False
                DataGridView1.Columns(11).Visible = False


                DataGridView1.Columns(12).Visible = False
                DataGridView1.Columns(15).Visible = False
                DataGridView1.Columns(17).Visible = False
                DataGridView1.Columns(18).Visible = False

                DataGridView1.Columns(21).Visible = False
                DataGridView1.Columns(23).Visible = False
                'DataGridView1.Columns(25).Visible = False
            Next


        Catch ex As Exception
            ' MessageBox.Show("First Refresh And Refetch Marks")
            'MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub FecthMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecthMarksToolStripMenuItem.Click
        If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
            MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
        Else

            DataGridView1.Columns.Clear()

            fetchexistingmarks()
        End If
    End Sub

    Private Sub EditMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
    Private Sub OlevelClassReportsS3AndS4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClassreportALevelSciences.Show()
    End Sub

    Private Sub CLASSREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLASSREPORTToolStripMenuItem.Click
        GeneralArtsReport.Show()
    End Sub

    Private Sub ALevelClassReportsSciencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ALEVELSINGLESTUDENTSSCIENCEREPORT.Show()
    End Sub
    Public Sub fillinitial()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select initial from reportcards.teachers where subject='" + txt_subject.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim classes As String = myReader.GetString("initial").ToString()


                txt_initial.Text = classes

            End While

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub txt_subject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_subject.SelectedIndexChanged
        FILLcode()
        fillinitial()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Columns.Clear()

        DataGridView1.Columns.Add(P1MID)
        DataGridView1.Columns.Add(P1END)
        DataGridView1.Columns.Add(AVGP1)
        DataGridView1.Columns.Add(GRADEP1)
        DataGridView1.Columns.Add(AGGREGATEP1)

        DataGridView1.Columns.Add(P2MID)

        DataGridView1.Columns.Add(P2END)
        DataGridView1.Columns.Add(AVGP2)
        DataGridView1.Columns.Add(GRADEP2)
        DataGridView1.Columns.Add(AGGREGATEP2)
        DataGridView1.Columns.Add(P3MID)
        DataGridView1.Columns.Add(P3END)
        DataGridView1.Columns.Add(AVGP3)
        DataGridView1.Columns.Add(GRADEP3)
        DataGridView1.Columns.Add(AGGREGATEP3)
        DataGridView1.Columns.Add(SCORE)
        DataGridView1.Columns.Add(REMARK)
        DataGridView1.Columns.Add(POINTS)

        DataGridView1.Columns.Add(P1BOT)
        DataGridView1.Columns.Add(P2BOT)
        DataGridView1.Columns.Add(P3BOT)
        DataGridView1.Columns.Add(P4MID)
        DataGridView1.Columns.Add(P4END)
        DataGridView1.Columns.Add(P4AVG)
        DataGridView1.Columns.Add(P4GRADE)
        DataGridView1.Columns.Add(P4AGGREGATE)
       
        setdefault()
        fill_name()
    End Sub

    Private Sub SciencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MIDREPORTSSCIENCIES.Show()
    End Sub

    Private Sub ArtsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MIDREPORTSARTS.Show()
    End Sub

    Private Sub txt_password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_password.TextChanged
        If (txt_password.Text = "five17") Then
            txt_class.Text = "S5"
        ElseIf (txt_password.Text = "six17") Then
            txt_class.Text = "S6"
        End If
    End Sub

    Private Sub MarkSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarkSheetToolStripMenuItem.Click
        '  AlevelGridmarksheet.Show()
    End Sub

    Private Sub ProcessTotalPointsForEachStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessTotalPointsForEachStudentToolStripMenuItem.Click
        Try
            If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
                MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")

            Else

                GetTotalpointseachstudent.Show()
            End If
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P4.TextChanged

    End Sub

    Private Sub ManageStudentsGivenExtraSubjectsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        STUDENTS_EXTRA_SUBJECTS_ALEVEL.Show()
    End Sub

    Private Sub txt_offersbot_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_offersbot.SelectedIndexChanged
        If (txt_level.Text.Length > 0 And txt_report.Text.Length > 0) Then
            DataGridView1.Enabled = True
            setdefault()
        Else

        End If
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub PRINTALEVELREPORTSSINGLEASSESSIMENTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRINTALEVELREPORTSSINGLEASSESSIMENTSToolStripMenuItem.Click
        A.Show()

    End Sub

    Private Sub UploadMarksFromExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadMarksFromExcelToolStripMenuItem.Click
        IMPORTALEVELMARKS.Show()

    End Sub

    Private Sub PrintPerfomanceListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPerfomanceListToolStripMenuItem.Click
        ATOTALPOINTS.Show()

    End Sub
End Class