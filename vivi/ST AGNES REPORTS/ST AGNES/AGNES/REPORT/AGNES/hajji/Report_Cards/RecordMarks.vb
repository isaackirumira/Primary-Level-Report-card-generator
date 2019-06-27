Imports MySql.Data.MySqlClient
Public Class RecordMarks

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
    Dim r3 As String = "Aim higher"
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
    Dim c7 As String = "Work Harder"
   
    ''' alevel grading ends
    Dim v10 As String = "-"
    Dim s10 As String = "-"
    Dim r10 As String = "Missed Paper"
    Dim tb As TextBox
    Dim maxid As String
    Dim entryid As String
    Dim DIV1 As String = "A"
    Dim DIV2 As String = "B"
    Dim DIV3 As String = "C"
    Dim SUBJ1 As String = "Number concepts"
    Dim SUBJ2 As String = "Language"
    Dim SUBJ3 As String = "Social Devt"
    Dim SUBJ4 As String = "Health Habits"
    Dim SUBJ5 As String = "Reading"
    Dim SUBJ6 As String = "Writing"
    Dim SUBJ7 As String = "Oral"
    Dim SUBJ8 As String = "Behaviour"
    Dim SUBJ9 As String = "Smartness"
    Dim SUBJ10 As String = "Attendance"
    Dim SUBJ11 As String = "Sharing"
    Dim SUBJ12 As String = "Music Dance Rhymes"
    Public Sub MIDYEKA()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            ' If (Double.Parse(DataGridView1.Item(0, i2).Value) > 30.0) Then

            'MessageBox.Show("Mid Must be out of 30 and End out of 70")

            ' DataGridView1.Item(0, i2).Value = "-"
            'DataGridView1.Item(1, i2).Value = "-"

            ' Else

            DataGridView1.Item(4, i2).Value = ((Double.Parse(DataGridView1.Item(1, i2).Value)))
            If (Double.Parse(DataGridView1.Item(4, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 100) Then
                DataGridView1.Item(5, i2).Value = v1
                DataGridView1.Item(6, i2).Value = s1
                DataGridView1.Item(7, i2).Value = r1
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 89.5) Then
                DataGridView1.Item(5, i2).Value = v2
                DataGridView1.Item(6, i2).Value = s2
                DataGridView1.Item(7, i2).Value = r2
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 79.5) Then
                DataGridView1.Item(5, i2).Value = v3
                DataGridView1.Item(6, i2).Value = s3
                DataGridView1.Item(7, i2).Value = r3
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 69.5) Then
                DataGridView1.Item(5, i2).Value = v4
                DataGridView1.Item(6, i2).Value = s4
                DataGridView1.Item(7, i2).Value = r4
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 64.5) Then
                DataGridView1.Item(5, i2).Value = v5
                DataGridView1.Item(6, i2).Value = s5
                DataGridView1.Item(7, i2).Value = r5
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 59.5) Then
                DataGridView1.Item(5, i2).Value = v6
                DataGridView1.Item(6, i2).Value = s6
                DataGridView1.Item(7, i2).Value = r6
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 49.5) Then
                DataGridView1.Item(5, i2).Value = v7
                DataGridView1.Item(6, i2).Value = s7
                DataGridView1.Item(7, i2).Value = r7
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 44.5) Then
                DataGridView1.Item(5, i2).Value = v8
                DataGridView1.Item(6, i2).Value = s8
                DataGridView1.Item(7, i2).Value = r8
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 39.5) Then
                DataGridView1.Item(5, i2).Value = v9
                DataGridView1.Item(6, i2).Value = s9
                DataGridView1.Item(7, i2).Value = r9

            ElseIf (DataGridView1.Item(0, i2).Value = 0) Or (DataGridView1.Item(1, i2).Value = 0) Or (DataGridView1.Item(2, i2).Value = 0) Or (DataGridView1.Item(3, i2).Value = 0) Then
                DataGridView1.Item(5, i2).Value = v10
                DataGridView1.Item(6, i2).Value = s10
                DataGridView1.Item(7, i2).Value = r10



                'End If
            End If

        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub loadcompetences()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.competences where subject='" + txt_subject.Text + "' and class='" + txt_class.Text + "' and term='" + txt_term.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            If (myReader.Read()) Then
                Dim competence As String = myReader.GetString("competence").ToString()
                RichTextBox1.Text = competence

            Else
                MessageBox.Show("Re-Enter Password & Try Again")
            End If

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub olevel3SETS()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            ' If (Double.Parse(DataGridView1.Item(0, i2).Value) > 30.0) Then

            'MessageBox.Show("Mid Must be out of 30 and End out of 70")

            ' DataGridView1.Item(0, i2).Value = "-"
            'DataGridView1.Item(1, i2).Value = "-"

            ' Else

            DataGridView1.Item(4, i2).Value = ((Double.Parse(DataGridView1.Item(0, i2).Value)) + (Double.Parse(DataGridView1.Item(1, i2).Value)) + (Double.Parse(DataGridView1.Item(2, i2).Value)) + (Double.Parse(DataGridView1.Item(3, i2).Value))) / 4
            If (Double.Parse(DataGridView1.Item(4, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 100) Then
                DataGridView1.Item(5, i2).Value = v1
                DataGridView1.Item(6, i2).Value = s1
                DataGridView1.Item(7, i2).Value = r1
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 89.5) Then
                DataGridView1.Item(5, i2).Value = v2
                DataGridView1.Item(6, i2).Value = s2
                DataGridView1.Item(7, i2).Value = r2
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 79.5) Then
                DataGridView1.Item(5, i2).Value = v3
                DataGridView1.Item(6, i2).Value = s3
                DataGridView1.Item(7, i2).Value = r3
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 69.5) Then
                DataGridView1.Item(5, i2).Value = v4
                DataGridView1.Item(6, i2).Value = s4
                DataGridView1.Item(7, i2).Value = r4
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 64.5) Then
                DataGridView1.Item(5, i2).Value = v5
                DataGridView1.Item(6, i2).Value = s5
                DataGridView1.Item(7, i2).Value = r5
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 59.5) Then
                DataGridView1.Item(5, i2).Value = v6
                DataGridView1.Item(6, i2).Value = s6
                DataGridView1.Item(7, i2).Value = r6
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 49.5) Then
                DataGridView1.Item(5, i2).Value = v7
                DataGridView1.Item(6, i2).Value = s7
                DataGridView1.Item(7, i2).Value = r7
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 44.5) Then
                DataGridView1.Item(5, i2).Value = v8
                DataGridView1.Item(6, i2).Value = s8
                DataGridView1.Item(7, i2).Value = r8
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 39.5) Then
                DataGridView1.Item(5, i2).Value = v9
                DataGridView1.Item(6, i2).Value = s9
                DataGridView1.Item(7, i2).Value = r9

            ElseIf (DataGridView1.Item(0, i2).Value = 0) Or (DataGridView1.Item(1, i2).Value = 0) Or (DataGridView1.Item(2, i2).Value = 0) Or (DataGridView1.Item(3, i2).Value = 0) Then
                DataGridView1.Item(5, i2).Value = v10
                DataGridView1.Item(6, i2).Value = s10
                DataGridView1.Item(7, i2).Value = r10



                'End If
            End If

        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub olevelgradingENDONLY()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            ' If (Double.Parse(DataGridView1.Item(0, i2).Value) > 30.0) Then

            'MessageBox.Show("Mid Must be out of 30 and End out of 70")

            ' DataGridView1.Item(0, i2).Value = "-"
            'DataGridView1.Item(1, i2).Value = "-"

            ' Else

            DataGridView1.Item(4, i2).Value = (Double.Parse(DataGridView1.Item(2, i2).Value) + Double.Parse(DataGridView1.Item(3, i2).Value)) / 2

            If (Double.Parse(DataGridView1.Item(4, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 100) Then
                DataGridView1.Item(5, i2).Value = v1
                DataGridView1.Item(6, i2).Value = s1
                DataGridView1.Item(7, i2).Value = r1
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 89.5) Then
                DataGridView1.Item(5, i2).Value = v2
                DataGridView1.Item(6, i2).Value = s2
                DataGridView1.Item(7, i2).Value = r2
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 79.5) Then
                DataGridView1.Item(5, i2).Value = v3
                DataGridView1.Item(6, i2).Value = s3
                DataGridView1.Item(7, i2).Value = r3
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 69.5) Then
                DataGridView1.Item(5, i2).Value = v4
                DataGridView1.Item(6, i2).Value = s4
                DataGridView1.Item(7, i2).Value = r4
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 64.5) Then
                DataGridView1.Item(5, i2).Value = v5
                DataGridView1.Item(6, i2).Value = s5
                DataGridView1.Item(7, i2).Value = r5
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 59.5) Then
                DataGridView1.Item(5, i2).Value = v6
                DataGridView1.Item(6, i2).Value = s6
                DataGridView1.Item(7, i2).Value = r6
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 49.5) Then
                DataGridView1.Item(5, i2).Value = v7
                DataGridView1.Item(6, i2).Value = s7
                DataGridView1.Item(7, i2).Value = r7
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 44.5) Then
                DataGridView1.Item(5, i2).Value = v8
                DataGridView1.Item(6, i2).Value = s8
                DataGridView1.Item(7, i2).Value = r8
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 39.5) Then
                DataGridView1.Item(5, i2).Value = v9
                DataGridView1.Item(6, i2).Value = s9
                DataGridView1.Item(7, i2).Value = r9







            ElseIf (DataGridView1.Item(0, i2).Value = 0) Or (DataGridView1.Item(1, i2).Value = 0) Or (DataGridView1.Item(2, i2).Value = 0 Or (DataGridView1.Item(3, i2).Value = 0)) Then
                DataGridView1.Item(5, i2).Value = v10
                DataGridView1.Item(6, i2).Value = s10
                DataGridView1.Item(7, i2).Value = r10



                'End If
            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub olevelgradingbotandend()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            ' If (Double.Parse(DataGridView1.Item(0, i2).Value) > 30.0) Then

            'MessageBox.Show("Mid Must be out of 30 and End out of 70")

            ' DataGridView1.Item(0, i2).Value = "-"
            'DataGridView1.Item(1, i2).Value = "-"

            ' Else

            DataGridView1.Item(3, i2).Value = ((Double.Parse(DataGridView1.Item(0, i2).Value)) + (Double.Parse(DataGridView1.Item(2, i2).Value))) / 2
            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = v1
                DataGridView1.Item(5, i2).Value = s1
                DataGridView1.Item(6, i2).Value = r1
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = v2
                DataGridView1.Item(5, i2).Value = s2
                DataGridView1.Item(6, i2).Value = r2
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = v3
                DataGridView1.Item(5, i2).Value = s3
                DataGridView1.Item(6, i2).Value = r3
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = v4
                DataGridView1.Item(5, i2).Value = s4
                DataGridView1.Item(6, i2).Value = r4
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = v5
                DataGridView1.Item(5, i2).Value = s5
                DataGridView1.Item(6, i2).Value = r5
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = v6
                DataGridView1.Item(5, i2).Value = s6
                DataGridView1.Item(6, i2).Value = r6
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = v7
                DataGridView1.Item(5, i2).Value = s7
                DataGridView1.Item(6, i2).Value = r7
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = v8
                DataGridView1.Item(5, i2).Value = s8
                DataGridView1.Item(6, i2).Value = r8
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = v9
                DataGridView1.Item(5, i2).Value = s9
                DataGridView1.Item(6, i2).Value = r9







            ElseIf (DataGridView1.Item(0, i2).Value = 0) Or (DataGridView1.Item(1, i2).Value = 0) Or (DataGridView1.Item(2, i2).Value = 0) Then
                DataGridView1.Item(4, i2).Value = v10
                DataGridView1.Item(5, i2).Value = s10
                DataGridView1.Item(6, i2).Value = r10



                'End If
            End If

        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub olevelgradingNOBOT()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            ' If (Double.Parse(DataGridView1.Item(0, i2).Value) > 30.0) Then

            'MessageBox.Show("Mid Must be out of 30 and End out of 70")

            ' DataGridView1.Item(0, i2).Value = "-"
            'DataGridView1.Item(1, i2).Value = "-"

            ' Else

            DataGridView1.Item(3, i2).Value = ((Double.Parse(DataGridView1.Item(1, i2).Value)) + (Double.Parse(DataGridView1.Item(2, i2).Value))) / 2
            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = v1
                DataGridView1.Item(5, i2).Value = s1
                DataGridView1.Item(6, i2).Value = r1
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = v2
                DataGridView1.Item(5, i2).Value = s2
                DataGridView1.Item(6, i2).Value = r2
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = v3
                DataGridView1.Item(5, i2).Value = s3
                DataGridView1.Item(6, i2).Value = r3
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = v4
                DataGridView1.Item(5, i2).Value = s4
                DataGridView1.Item(6, i2).Value = r4
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = v5
                DataGridView1.Item(5, i2).Value = s5
                DataGridView1.Item(6, i2).Value = r5
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = v6
                DataGridView1.Item(5, i2).Value = s6
                DataGridView1.Item(6, i2).Value = r6
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = v7
                DataGridView1.Item(5, i2).Value = s7
                DataGridView1.Item(6, i2).Value = r7
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = v8
                DataGridView1.Item(5, i2).Value = s8
                DataGridView1.Item(6, i2).Value = r8
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = v9
                DataGridView1.Item(5, i2).Value = s9
                DataGridView1.Item(6, i2).Value = r9







            ElseIf (DataGridView1.Item(0, i2).Value = 0) Or (DataGridView1.Item(1, i2).Value = 0) Or (DataGridView1.Item(2, i2).Value = 0) Then
                DataGridView1.Item(4, i2).Value = v10
                DataGridView1.Item(5, i2).Value = s10
                DataGridView1.Item(6, i2).Value = r10



                'End If
            End If

        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub olevelgradingmidNOBOT()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            ' If (Double.Parse(DataGridView1.Item(0, i2).Value) > 30.0) Then

            'MessageBox.Show("Mid Must be out of 30 and End out of 70")

            ' DataGridView1.Item(0, i2).Value = "-"
            'DataGridView1.Item(1, i2).Value = "-"

            ' Else

            DataGridView1.Item(4, i2).Value = (Double.Parse(DataGridView1.Item(0, i2).Value))
            If (Double.Parse(DataGridView1.Item(4, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 100) Then
                DataGridView1.Item(5, i2).Value = v1
                DataGridView1.Item(6, i2).Value = s1
                DataGridView1.Item(7, i2).Value = r1
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 89.5) Then
                DataGridView1.Item(5, i2).Value = v2
                DataGridView1.Item(6, i2).Value = s2
                DataGridView1.Item(7, i2).Value = r2
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 79.5) Then
                DataGridView1.Item(5, i2).Value = v3
                DataGridView1.Item(6, i2).Value = s3
                DataGridView1.Item(7, i2).Value = r3
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 69.5) Then
                DataGridView1.Item(5, i2).Value = v4
                DataGridView1.Item(6, i2).Value = s4
                DataGridView1.Item(7, i2).Value = r4
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 64.5) Then
                DataGridView1.Item(5, i2).Value = v5
                DataGridView1.Item(6, i2).Value = s5
                DataGridView1.Item(7, i2).Value = r5
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 59.5) Then
                DataGridView1.Item(5, i2).Value = v6
                DataGridView1.Item(6, i2).Value = s6
                DataGridView1.Item(7, i2).Value = r6
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 49.5) Then
                DataGridView1.Item(5, i2).Value = v7
                DataGridView1.Item(6, i2).Value = s7
                DataGridView1.Item(7, i2).Value = r7
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 44.5) Then
                DataGridView1.Item(5, i2).Value = v8
                DataGridView1.Item(6, i2).Value = s8
                DataGridView1.Item(7, i2).Value = r8
            ElseIf (Double.Parse(DataGridView1.Item(4, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(4, i2).Value) <= 39.5) Then
                DataGridView1.Item(5, i2).Value = v9
                DataGridView1.Item(6, i2).Value = s9
                DataGridView1.Item(7, i2).Value = r9







            ElseIf (DataGridView1.Item(0, i2).Value = 0) Or (DataGridView1.Item(1, i2).Value = 0) Or (DataGridView1.Item(2, i2).Value = 0 Or (DataGridView1.Item(3, i2).Value = 0)) Then
                DataGridView1.Item(5, i2).Value = v10
                DataGridView1.Item(6, i2).Value = s10
                DataGridView1.Item(7, i2).Value = r10



                'End If
            End If

        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub olevelgradingbot()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            ' If (Double.Parse(DataGridView1.Item(0, i2).Value) > 30.0) Then

            'MessageBox.Show("Mid Must be out of 30 and End out of 70")

            ' DataGridView1.Item(0, i2).Value = "-"
            'DataGridView1.Item(1, i2).Value = "-"

            ' Else

            DataGridView1.Item(3, i2).Value = Double.Parse(DataGridView1.Item(0, i2).Value)
            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = v1
                DataGridView1.Item(5, i2).Value = s1
                DataGridView1.Item(6, i2).Value = r1
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = v2
                DataGridView1.Item(5, i2).Value = s2
                DataGridView1.Item(6, i2).Value = r2
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = v3
                DataGridView1.Item(5, i2).Value = s3
                DataGridView1.Item(6, i2).Value = r3
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = v4
                DataGridView1.Item(5, i2).Value = s4
                DataGridView1.Item(6, i2).Value = r4
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = v5
                DataGridView1.Item(5, i2).Value = s5
                DataGridView1.Item(6, i2).Value = r5
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = v6
                DataGridView1.Item(5, i2).Value = s6
                DataGridView1.Item(6, i2).Value = r6
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = v7
                DataGridView1.Item(5, i2).Value = s7
                DataGridView1.Item(6, i2).Value = r7
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = v8
                DataGridView1.Item(5, i2).Value = s8
                DataGridView1.Item(6, i2).Value = r8
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = v9
                DataGridView1.Item(5, i2).Value = s9
                DataGridView1.Item(6, i2).Value = r9







            ElseIf (DataGridView1.Item(0, i2).Value = 0) Or (DataGridView1.Item(1, i2).Value = 0) Or (DataGridView1.Item(2, i2).Value = 0) Then
                DataGridView1.Item(4, i2).Value = v10
                DataGridView1.Item(5, i2).Value = s10
                DataGridView1.Item(6, i2).Value = r10



                'End If
            End If

        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub deletemarksgrades()

        Try




            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from reportcards.grades where class='" + txt_class.Text + "' and year='" + txt_year.Text + "' and term='" + txt_term.Text + "' and subject='" + txt_subject.Text + "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()

            myReader = SelectCommand.ExecuteReader()




            mycon.Close()


        Catch ex As Exception
            'MessageBox.Show(ex.Message)




        End Try
    End Sub
    Public Sub Savedatagrades()
        If (txt_subject.Text = "" And txt_level.Text = "") Then
            MessageBox.Show("Subject or level Missing")
        Else




            Try
                Dim i2 As Integer
                i2 = DataGridView1.CurrentRow.Index



                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim constring As String = "datasource=localhost;port=3306;username=root;"
                    Dim con As New MySqlConnection(constring)
                    Dim cmd As New MySqlCommand("INSERT INTO reportcards.grades(class,Class_Teacher,year,name,subject,term,date,initial,password,mid,end,end2,average,grade,aggregate,remark,entryid,bot) VALUES(@class,@classteacher,@year,@name, @subject, @term, @date, @initial, @password, @mid,@end,@end2,@average,@grade,@aggregate,@remark,@entryid,@bot)", con)
                    cmd.Parameters.AddWithValue("@class", txt_class.Text)
                    cmd.Parameters.AddWithValue("@classteacher", txt_classteacher.Text)
                    cmd.Parameters.AddWithValue("@year", txt_year.Text)
                    cmd.Parameters.AddWithValue("@name", row.Cells("name").Value)
                    cmd.Parameters.AddWithValue("@subject", txt_subject.Text)
                    cmd.Parameters.AddWithValue("@term", txt_term.Text)
                    cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                    cmd.Parameters.AddWithValue("@initial", txt_initial.Text)
                    cmd.Parameters.AddWithValue("@password", txt_password.Text)

                    cmd.Parameters.AddWithValue("@mid", row.Cells("MID").Value)
                    cmd.Parameters.AddWithValue("@end", row.Cells("EOT").Value)
                    cmd.Parameters.AddWithValue("@end2", row.Cells("end2").Value)
                    cmd.Parameters.AddWithValue("@average", row.Cells("AVERAGE").Value)

                    cmd.Parameters.AddWithValue("@grade", row.Cells("GRADE").Value)

                    cmd.Parameters.AddWithValue("@aggregate", row.Cells("AGGREGATE").Value)
                    cmd.Parameters.AddWithValue("@remark", row.Cells("REMARK").Value)
                    cmd.Parameters.AddWithValue("@entryid", txt_entryid.Text)
                    cmd.Parameters.AddWithValue("@bot", row.Cells("BOT").Value)
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





    Public Sub fetchexistingmarks()

        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("SELECT  BOT,MID,END AS EOT,END2,AVERAGE,GRADE,AGGREGATE,REMARK,NAME  FROM reportcards.marks where name in (SELECT distinct name from reportcards.marks) and class='" + txt_class.Text + "' and year='" + txt_year.Text + "' and term='" + txt_term.Text + "' and subject='" + txt_subject.Text + "' GROUP BY name ;", conDatabase)
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

                'DataGridView1.Columns(0).Visible = False

            Next



        Catch ex As Exception
            MessageBox.Show("Fill all fields")
            'MessageBox.Show(ex.Message)

        End Try



    End Sub
    Public Sub deletemarks()

        Try




            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from reportcards.marks where class='" + txt_class.Text + "' and year='" + txt_year.Text + "' and term='" + txt_term.Text + "' and subject='" + txt_subject.Text + "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()

            myReader = SelectCommand.ExecuteReader()




            mycon.Close()


        Catch ex As Exception
            'MessageBox.Show(ex.Message)




        End Try
    End Sub

    Public Sub checktoseeifmarksexists()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.marks where class='" + txt_class.Text + "' and year='" + txt_year.Text + "' and term='" + txt_term.Text + "' and subject='" + txt_subject.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1

            End If


            If (count = 0) Then
                Checkexistingsubjects()
            ElseIf (count = 1) Then
                updatemarks()

            End If


            mycon.Close()


        Catch ex As Exception
            'MessageBox.Show(ex.Message)


        End Try


    End Sub
    Public Sub updatemarks()

        If (txt_subject.Text = "" And txt_level.Text = "") Then
            MessageBox.Show("Subject or level Missing")
        Else
            deletemarks()
            deletemarksgrades()
            Savedata()
            Savedatagrades()


        End If
    End Sub




    Public Sub alevelgradingmid()


    End Sub

    Public Sub olevelgradingmid()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            ' If (Double.Parse(DataGridView1.Item(0, i2).Value) > 30.0) Then

            'MessageBox.Show("Mid Must be out of 30 and End out of 70")

            ' DataGridView1.Item(0, i2).Value = "-"
            'DataGridView1.Item(1, i2).Value = "-"

            ' Else

            DataGridView1.Item(3, i2).Value = (Double.Parse(DataGridView1.Item(1, i2).Value) + Double.Parse(DataGridView1.Item(2, i2).Value) + Double.Parse(DataGridView1.Item(3, i2).Value)) / 3

            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = v1
                DataGridView1.Item(5, i2).Value = s1
                DataGridView1.Item(6, i2).Value = r1
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = v2
                DataGridView1.Item(5, i2).Value = s2
                DataGridView1.Item(6, i2).Value = r2
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = v3
                DataGridView1.Item(5, i2).Value = s3
                DataGridView1.Item(6, i2).Value = r3
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = v4
                DataGridView1.Item(5, i2).Value = s4
                DataGridView1.Item(6, i2).Value = r4
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = v5
                DataGridView1.Item(5, i2).Value = s5
                DataGridView1.Item(6, i2).Value = r5
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = v6
                DataGridView1.Item(5, i2).Value = s6
                DataGridView1.Item(6, i2).Value = r6
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = v7
                DataGridView1.Item(5, i2).Value = s7
                DataGridView1.Item(6, i2).Value = r7
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = v8
                DataGridView1.Item(5, i2).Value = s8
                DataGridView1.Item(6, i2).Value = r8
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = v9
                DataGridView1.Item(5, i2).Value = s9
                DataGridView1.Item(6, i2).Value = r9







            ElseIf (DataGridView1.Item(0, i2).Value = 0) Or (DataGridView1.Item(1, i2).Value = 0) Or (DataGridView1.Item(2, i2).Value = 0) Then
                DataGridView1.Item(4, i2).Value = v10
                DataGridView1.Item(5, i2).Value = s10
                DataGridView1.Item(6, i2).Value = r10



                'End If
            End If
        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub setdefault()
        Try


            Dim dgval As String = "-"
            Dim dgvalf As String = "0"
            For Each row As DataGridViewRow In DataGridView1.Rows

                row.Cells("BOT").Value = dgval
                row.Cells("MID").Value = dgval

                row.Cells("EOT").Value = dgval

                row.Cells("AVERAGE").Value = dgval
                row.Cells("GRADE").Value = dgval
                row.Cells("AGGREGATE").Value = dgvalf
                row.Cells("REMARK").Value = dgval

            Next


        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub alevelgrading()


    End Sub

    Public Sub olevelgrading()
        Try


            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            ' If (Double.Parse(DataGridView1.Item(0, i2).Value) > 30.0) Then

            'MessageBox.Show("Mid Must be out of 30 and End out of 70")

            ' DataGridView1.Item(0, i2).Value = "-"
            'DataGridView1.Item(1, i2).Value = "-"

            ' Else

            DataGridView1.Item(3, i2).Value = ((Double.Parse(DataGridView1.Item(0, i2).Value)) + (Double.Parse(DataGridView1.Item(1, i2).Value)) + (Double.Parse(DataGridView1.Item(2, i2).Value))) / 3
            If (Double.Parse(DataGridView1.Item(3, i2).Value) >= 90 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 100) Then
                DataGridView1.Item(4, i2).Value = v1
                DataGridView1.Item(5, i2).Value = s1
                DataGridView1.Item(6, i2).Value = r1
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 80 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 89.5) Then
                DataGridView1.Item(4, i2).Value = v2
                DataGridView1.Item(5, i2).Value = s2
                DataGridView1.Item(6, i2).Value = r2
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 70 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 79.5) Then
                DataGridView1.Item(4, i2).Value = v3
                DataGridView1.Item(5, i2).Value = s3
                DataGridView1.Item(6, i2).Value = r3
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 65 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 69.5) Then
                DataGridView1.Item(4, i2).Value = v4
                DataGridView1.Item(5, i2).Value = s4
                DataGridView1.Item(6, i2).Value = r4
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 60 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 64.5) Then
                DataGridView1.Item(4, i2).Value = v5
                DataGridView1.Item(5, i2).Value = s5
                DataGridView1.Item(6, i2).Value = r5
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 50 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 59.5) Then
                DataGridView1.Item(4, i2).Value = v6
                DataGridView1.Item(5, i2).Value = s6
                DataGridView1.Item(6, i2).Value = r6
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 45 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 49.5) Then
                DataGridView1.Item(4, i2).Value = v7
                DataGridView1.Item(5, i2).Value = s7
                DataGridView1.Item(6, i2).Value = r7
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 40 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 44.5) Then
                DataGridView1.Item(4, i2).Value = v8
                DataGridView1.Item(5, i2).Value = s8
                DataGridView1.Item(6, i2).Value = r8
            ElseIf (Double.Parse(DataGridView1.Item(3, i2).Value) >= 0 And Double.Parse(DataGridView1.Item(3, i2).Value) <= 39.5) Then
                DataGridView1.Item(4, i2).Value = v9
                DataGridView1.Item(5, i2).Value = s9
                DataGridView1.Item(6, i2).Value = r9







            ElseIf (DataGridView1.Item(0, i2).Value = 0) Or (DataGridView1.Item(1, i2).Value = 0) Or (DataGridView1.Item(2, i2).Value = 0) Then
                DataGridView1.Item(4, i2).Value = v10
                DataGridView1.Item(5, i2).Value = s10
                DataGridView1.Item(6, i2).Value = r10



                'End If
            End If

        Catch ex As Exception
            ' 'MessageBox.Show(ex.Message)
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
                    Dim constring As String = "datasource=localhost;port=3306;username=root;"
                    Dim con As New MySqlConnection(constring)
                    Dim cmd As New MySqlCommand("INSERT INTO reportcards.marks(class,Class_Teacher,year,name,subject,term,date,initial,password,mid,end,end2,average,grade,aggregate,remark,entryid,bot,code,assessement,competence) VALUES(@class,@classteacher,@year,@name, @subject, @term, @date, @initial, @password, @mid,@end,@end2,@average,@grade,@aggregate,@remark,@entryid,@bot,@code,@assessement,@competence)", con)





                    cmd.Parameters.AddWithValue("@class", txt_class.Text)
                    cmd.Parameters.AddWithValue("@classteacher", txt_classteacher.Text)
                    cmd.Parameters.AddWithValue("@year", txt_year.Text)
                    cmd.Parameters.AddWithValue("@name", row.Cells("name").Value)
                    cmd.Parameters.AddWithValue("@subject", txt_subject.Text)
                    cmd.Parameters.AddWithValue("@term", txt_term.Text)
                    cmd.Parameters.AddWithValue("@date", DateTimePicker1.Text)
                    cmd.Parameters.AddWithValue("@initial", txt_initial.Text)
                    cmd.Parameters.AddWithValue("@password", txt_password.Text)

                    cmd.Parameters.AddWithValue("@mid", row.Cells("MID").Value)
                    cmd.Parameters.AddWithValue("@end", row.Cells("EOT").Value)
                    cmd.Parameters.AddWithValue("@end2", row.Cells("end2").Value)
                    cmd.Parameters.AddWithValue("@average", row.Cells("AVERAGE").Value)

                    cmd.Parameters.AddWithValue("@grade", row.Cells("GRADE").Value)

                    cmd.Parameters.AddWithValue("@aggregate", row.Cells("AGGREGATE").Value)
                    cmd.Parameters.AddWithValue("@remark", row.Cells("REMARK").Value)
                    cmd.Parameters.AddWithValue("@entryid", txt_entryid.Text)
                    cmd.Parameters.AddWithValue("@bot", row.Cells("BOT").Value)
                    cmd.Parameters.AddWithValue("@code", txt_code.Text)
                    cmd.Parameters.AddWithValue("@assessement", txt_botoffered.Text)
                    cmd.Parameters.AddWithValue("@competence", RichTextBox1.Text)
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
    Public Sub Checkexistingsubjects()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.marks where subject='" & txt_subject.Text & "' and term='" & txt_term.Text & "' and year='" & txt_year.Text & "' and class='" + txt_class.Text + "';", mycon)
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


    Public Sub getmaxid()

        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select max(id) from reportcards.marks ;", mycon)
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
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        Try
            calculateaverage()
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
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


    Public Sub calculateaverage()

       
        If (txt_level.Text = "PRIMARY" And txt_report.Text = "BOT AND MID AND END ") Then
            olevel3SETS()

        ElseIf (txt_level.Text = "PRIMARY" And txt_report.Text = "MID") Then
            'olevelgradingmidNOBOT()
            MIDYEKA()

        ElseIf (txt_level.Text = "PRIMARY" And txt_report.Text = "BOT") Then
            olevelgradingmidNOBOT()

            ' ElseIf (txt_level.Text = "PRIMARY" And txt_report.Text = "END") Then
            'olevelgradingENDONLY()

        End If

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
    Public Sub FILLcode()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select code from reportcards.subjects where subject='" + txt_subject.Text + "' ;", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()

            While (myReader.Read())
                Dim classes As String = myReader.GetString("code").ToString()


                txt_code.Text = classes

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
    Private Sub RecordMarks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fill_classes()

            FILLSUBJECT()

            getmaxid()

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
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
        setdefault()
    End Sub

    Private Sub MenuStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Try
            fill_subjects()
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
            MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
        Else
            checktoseeifmarksexists()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub



    Private Sub DataGridView1_MarginChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.MarginChanged
        Try
            calculateaverage()
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub



    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub OverRollPerformanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
                MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")

            Else

                OverRollPerformance.Show()
            End If
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub txt_subject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_subject.SelectedIndexChanged
        fillinitial()
        FILLcode()
    End Sub

    Private Sub RankStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RankStudentsToolStripMenuItem.Click
        Try
            If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
                MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
            Else

                RankStudents.Show()
            End If
        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub EditMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
                MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
            Else

                EditMarks.Show()
            End If

        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub CLASSREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
            MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
        Else
            ClassReport.Show()
        End If
    End Sub

    Private Sub BestEightAggregatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BestEightAggregatesToolStripMenuItem.Click
        If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
            MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
        Else
            Testbest8.Show()
        End If
    End Sub

    Private Sub txt_level_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_level.SelectedIndexChanged
        If (txt_level.Text.Length > 0 And txt_report.Text.Length > 0) Then
            DataGridView1.Enabled = True
        Else

        End If
    End Sub

    Private Sub OlevelClassReportsS3AndS4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
            MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
        Else
            Generalclassreports3s4.Show()
        End If
    End Sub

    Private Sub AlevelClassReportsArtsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
            MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
        Else


        End If
    End Sub

    Private Sub ALevelClassReportsSciencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
            MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
        Else


        End If
    End Sub

    Private Sub GenerateTotalPointsForEachStudentByClassTermAndYearEssentialForS5AndS6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
            MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
        Else
            AlevelTotalpoints.Show()

        End If
    End Sub

    Private Sub CLASSLISTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub txt_password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_password.TextChanged
        If (txt_password.Text = "one17") Then
            txt_class.Text = "S1"
        ElseIf (txt_password.Text = "two17") Then
            txt_class.Text = "S2"
        ElseIf (txt_password.Text = "three17") Then
            txt_class.Text = "S3"
        ElseIf (txt_password.Text = "four17") Then
            txt_class.Text = "S4"
        ElseIf (txt_password.Text = "five17") Then
            txt_class.Text = "S5"
        ElseIf (txt_password.Text = "six17") Then
            txt_class.Text = "S5"
        End If
    End Sub

    Private Sub txt_report_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_report.SelectedIndexChanged
        If (txt_level.Text.Length > 0 And txt_report.Text.Length > 0) Then
            DataGridView1.Enabled = True
        Else

        End If
    End Sub

    Private Sub FecthMarksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecthMarksToolStripMenuItem.Click
        If (txt_subject.Text = "") Then
            MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
        Else
            DataGridView1.Columns.Clear()
            fetchexistingmarks()
        End If
    End Sub

    Private Sub ClassListsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
            MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
        Else

        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SINGLECLASSREPORTS1S2.Show()
    End Sub

    Private Sub SINGLESTUDENTSREPORTS3ANDS4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SINGLECLASSREPORTS3S4.Show()
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add(BOT)
        DataGridView1.Columns.Add(MID)
        DataGridView1.Columns.Add(EOT)
        DataGridView1.Columns.Add(END2)
        DataGridView1.Columns.Add(AVERAGE)
        DataGridView1.Columns.Add(GRADE)
        DataGridView1.Columns.Add(AGGREGATE)
        DataGridView1.Columns.Add(REMARK)
        fill_name()
        setdefault()



    End Sub

    Private Sub S1ANDS2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        marksheets1s2.Show()
    End Sub

    Private Sub S3ANDS4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        marksheets3s4.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Aa As String

        Aa = MsgBox("are you sure u want to add on this student?", vbYesNo, "Question")

        If Aa = vbYes Then
            Try

                Dim constring As String = "datasource=localhost;port=3306;username=root;"
                Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
                Dim cmdDatabase As MySqlCommand = New MySqlCommand("SELECT  BOT,MID,END AS EOT,END2,AVERAGE,GRADE,AGGREGATE,REMARK,NAME  FROM reportcards.marks where name in (SELECT distinct name from reportcards.marks) and class='" + txt_class.Text + "' and year='" + txt_year.Text + "' and term='" + txt_term.Text + "' and subject='" + txt_subject.Text + "' GROUP BY name ;", conDatabase)
                Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
                sda.SelectCommand = cmdDatabase
                Dim dbDataset As DataTable = New DataTable()

                DataGridView1.DataSource = dbDataset

                'add row
                dbDataset.Rows.Add()



                sda.Fill(dbDataset)
                Dim bSource As BindingSource = New BindingSource()
                bSource.DataSource = dbDataset
                DataGridView1.DataSource = bSource
                sda.Update(dbDataset)
                conDatabase.Close()




            Catch ex As Exception

                'MessageBox.Show(ex.Message)

            End Try
        End If


    End Sub

    Private Sub S1ANDS2ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GENERALMARKSHEETS1ANDS2.Show()
    End Sub

    Private Sub S3ANDS4ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GENERALMAEKSHEETS3ANDS4.Show()
    End Sub

    Private Sub ANALYSISToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' analysis.Show()
    End Sub

    Private Sub txt_botoffered_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_botoffered.SelectedIndexChanged
        If (txt_botoffered.Text.Length > 0) Then
            DataGridView1.Enabled = True
            txt_report.Text = txt_botoffered.Text
        Else

        End If
    End Sub

    Private Sub PrintClassReportS3AndS4MIDANDENDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ONLYDONEMIDENDFORM.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FORMBOTENDS3S4.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        S1S2FORMBOTANDEND.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        S1ANDS2MIDANDENDFORM.Show()
    End Sub

    Private Sub SAVEMARKSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Checkexistingsubjects()
    End Sub

    Private Sub GenerateBest8ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateBest8ToolStripMenuItem.Click
        OverRollPerformance.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BOTONLYS1ANDS2.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        ANALYSISFORM.Show()
    End Sub

    Private Sub CLICKTOSAVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLICKTOSAVEToolStripMenuItem.Click
        If (txt_subject.Text = "" Or txt_level.Text = "" Or txt_class.Text = "" Or txt_term.Text = "" Or txt_year.Text = "") Then
            MessageBox.Show("Please you must fill the class , term , year , subject and level to continue")
        Else
            checktoseeifmarksexists()
        End If
    End Sub

    Private Sub GENERALMARKSHEETToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GENERALMARKSHEETToolStripMenuItem.Click
        marksheets1s2.Show()
    End Sub

    Private Sub SAVEToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEToolStripMenuItem.Click

    End Sub

    Private Sub PrintReportspremockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SINGLE_SET_EXAMS.Show()
    End Sub

    Private Sub PrintReportsmidOnlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SINGLE_SET_EXAMS.Show()
    End Sub

    Private Sub PrintReportsEndOnlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SINGLE_SET_EXAMS.Show()
    End Sub

    Private Sub PrintReportscontinousAssessementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SINGLE_SET_EXAMS.Show()
    End Sub

    Private Sub PrintReportsmockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SINGLE_SET_EXAMS.Show()
    End Sub

    Private Sub PrintReportsmidAndContinousAssessementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CONTINOUS_ASSESSEMENT_AND_MID.Show()
    End Sub

    Private Sub UploadMarksFromExcellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadMarksFromExcellToolStripMenuItem.Click
        IMPORTOLEVELMARKS.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (txt_password.Text = "one17") Then
            txt_class.Text = "S1"
        ElseIf (txt_password.Text = "two17") Then
            txt_class.Text = "S2"
        ElseIf (txt_password.Text = "three17") Then
            txt_class.Text = "S3"
        ElseIf (txt_password.Text = "four17") Then
            txt_class.Text = "S4"
        ElseIf (txt_password.Text = "five17") Then
            txt_class.Text = "S5"
        ElseIf (txt_password.Text = "six17") Then
            txt_class.Text = "S5"
        End If
    End Sub

    Private Sub PrintReportsS3AndS4midAndEndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        S3PRINTOUT.Show()

    End Sub

    Private Sub S1AndS2ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S1AndS2ToolStripMenuItem.Click
        PRINTS1_AND_S2_PERFOMANCE_LIST.Show()

    End Sub

    Private Sub S3ANDS4ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S3ANDS4ToolStripMenuItem.Click
        PRINT_S3_AND_S4_PERFOMANCE_LIST.Show()

    End Sub

    Private Sub PRINTEMPTYMARKSHEETTOFILLINMARKSBYTEACHERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRINTEMPTYMARKSHEETTOFILLINMARKSBYTEACHERSToolStripMenuItem.Click
        PRINTEMPTYOLEVELMARKSHEET.Show()

    End Sub

    Private Sub PrintReportsWithCompetencesLowerClassesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintReportsWithCompetencesLowerClassesToolStripMenuItem.Click
        PRINTCOMPETENCEREPORT.Show()

    End Sub

    Private Sub PrintNurseryReportCardsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintNurseryReportCardsToolStripMenuItem.Click
        Babyreports.Show()

    End Sub
    Public Sub gradenusery()
        Try
          
            Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
            Dim con As New MySqlConnection(constring)

            '1
            Dim subj1a As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV1 + "' where  average=90 or average=91 or average=92 or average=93 or average=94 or average=95 or average=96 or average=97 or average=98 or average=99 or average=100 AND SUBJECT='" + SUBJ1 + "' ", con)
            Dim subj1b As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV2 + "' where  average=80 or average=81 or average=82 or average=83 or average=84 or average=85 or average=86 or average=87 or average=88 or average=89 or average=90 AND SUBJECT='" + SUBJ1 + "' ", con)
            Dim subj1c As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV3 + "' where  average  <80 AND SUBJECT='" + SUBJ1 + "' ", con)
            '2
            Dim subj2a As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV1 + "' where  average=90 or average=91 or average=92 or average=93 or average=94 or average=95 or average=96 or average=97 or average=98 or average=99 or average=100 AND SUBJECT='" + SUBJ2 + "' ", con)
            Dim subj2b As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV2 + "' where  average=80 or average=81 or average=82 or average=83 or average=84 or average=85 or average=86 or average=87 or average=88 or average=89 or average=90 AND SUBJECT='" + SUBJ2 + "' ", con)
            Dim subj2c As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV3 + "' where  average  <80 AND SUBJECT='" + SUBJ2 + "' ", con)

            '3
            Dim subj3a As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV1 + "' where  average=90 or average=91 or average=92 or average=93 or average=94 or average=95 or average=96 or average=97 or average=98 or average=99 or average=100 AND SUBJECT='" + SUBJ3 + "' ", con)
            Dim subj3b As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV2 + "' where  average=80 or average=81 or average=82 or average=83 or average=84 or average=85 or average=86 or average=87 or average=88 or average=89 or average=90 AND SUBJECT='" + SUBJ3 + "' ", con)
            Dim subj3c As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV3 + "' where  average  <80 AND SUBJECT='" + SUBJ3 + "' ", con)


            '4
            Dim subj4a As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV1 + "' where  average=90 or average=91 or average=92 or average=93 or average=94 or average=95 or average=96 or average=97 or average=98 or average=99 or average=100 AND SUBJECT='" + SUBJ4 + "' ", con)
            Dim subj4b As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV2 + "' where  average=80 or average=81 or average=82 or average=83 or average=84 or average=85 or average=86 or average=87 or average=88 or average=89 or average=90 AND SUBJECT='" + SUBJ4 + "' ", con)
            Dim subj4c As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV3 + "' where  average  <80 AND SUBJECT='" + SUBJ4 + "' ", con)

            '5
            Dim subj5a As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV1 + "' where  average=90 or average=91 or average=92 or average=93 or average=94 or average=95 or average=96 or average=97 or average=98 or average=99 or average=100 AND SUBJECT='" + SUBJ5 + "' ", con)
            Dim subj5b As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV2 + "' where  average=80 or average=81 or average=82 or average=83 or average=84 or average=85 or average=86 or average=87 or average=88 or average=89 or average=90 AND SUBJECT='" + SUBJ5 + "' ", con)
            Dim subj5c As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV3 + "' where  average  <80 AND SUBJECT='" + SUBJ5 + "' ", con)


            '6
            Dim subj6a As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV1 + "' where  average=90 or average=91 or average=92 or average=93 or average=94 or average=95 or average=96 or average=97 or average=98 or average=99 or average=100 AND SUBJECT='" + SUBJ6 + "' ", con)
            Dim subj6b As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV2 + "' where  average=80 or average=81 or average=82 or average=83 or average=84 or average=85 or average=86 or average=87 or average=88 or average=89 or average=90 AND SUBJECT='" + SUBJ6 + "' ", con)
            Dim subj6c As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV3 + "' where  average  <80 AND SUBJECT='" + SUBJ6 + "' ", con)



            '7
            Dim subj7a As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV1 + "' where  average=90 or average=91 or average=92 or average=93 or average=94 or average=95 or average=96 or average=97 or average=98 or average=99 or average=100 AND SUBJECT='" + SUBJ7 + "' ", con)
            Dim subj7b As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV2 + "' where  average=80 or average=81 or average=82 or average=83 or average=84 or average=85 or average=86 or average=87 or average=88 or average=89 or average=90 AND SUBJECT='" + SUBJ7 + "' ", con)
            Dim subj7c As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV3 + "' where  average  <80 AND SUBJECT='" + SUBJ7 + "' ", con)



            '8
            Dim subj8a As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV1 + "' where  average=90 or average=91 or average=92 or average=93 or average=94 or average=95 or average=96 or average=97 or average=98 or average=99 or average=100 AND SUBJECT='" + SUBJ8 + "' ", con)
            Dim subj8b As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV2 + "' where  average=80 or average=81 or average=82 or average=83 or average=84 or average=85 or average=86 or average=87 or average=88 or average=89 or average=90 AND SUBJECT='" + SUBJ8 + "' ", con)
            Dim subj8c As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV3 + "' where  average  <80 AND SUBJECT='" + SUBJ8 + "' ", con)


            '9
            Dim subj9a As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV1 + "' where  average=90 or average=91 or average=92 or average=93 or average=94 or average=95 or average=96 or average=97 or average=98 or average=99 or average=100 AND SUBJECT='" + SUBJ9 + "' ", con)
            Dim subj9b As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV2 + "' where  average=80 or average=81 or average=82 or average=83 or average=84 or average=85 or average=86 or average=87 or average=88 or average=89 or average=90 AND SUBJECT='" + SUBJ9 + "' ", con)
            Dim subj9c As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV3 + "' where  average  <80 AND SUBJECT='" + SUBJ9 + "' ", con)

            '10
            Dim subj10a As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV1 + "' where  average=90 or average=91 or average=92 or average=93 or average=94 or average=95 or average=96 or average=97 or average=98 or average=99 or average=100 AND SUBJECT='" + SUBJ10 + "' ", con)
            Dim subj10b As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV2 + "' where  average=80 or average=81 or average=82 or average=83 or average=84 or average=85 or average=86 or average=87 or average=88 or average=89 or average=90 AND SUBJECT='" + SUBJ10 + "' ", con)
            Dim subj10c As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV3 + "' where  average  <80 AND SUBJECT='" + SUBJ10 + "' ", con)

            '11
            Dim subj11a As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV1 + "' where  average=90 or average=91 or average=92 or average=93 or average=94 or average=95 or average=96 or average=97 or average=98 or average=99 or average=100 AND SUBJECT='" + SUBJ11 + "' ", con)
            Dim subj11b As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV2 + "' where  average=80 or average=81 or average=82 or average=83 or average=84 or average=85 or average=86 or average=87 or average=88 or average=89 or average=90 AND SUBJECT='" + SUBJ11 + "' ", con)
            Dim subj11c As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV3 + "' where  average  <80 AND SUBJECT='" + SUBJ11 + "' ", con)

            '12
            Dim subj12a As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV1 + "' where  average=90 or average=91 or average=92 or average=93 or average=94 or average=95 or average=96 or average=97 or average=98 or average=99 or average=100 AND SUBJECT='" + SUBJ12 + "' ", con)
            Dim subj12b As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV2 + "' where  average=80 or average=81 or average=82 or average=83 or average=84 or average=85 or average=86 or average=87 or average=88 or average=89 or average=90 AND SUBJECT='" + SUBJ12 + "' ", con)
            Dim subj12c As New MySqlCommand("update reportcards.MARKS set nursery='" + DIV3 + "' where  average  <80 AND SUBJECT='" + SUBJ12 + "' ", con)

            con.Open()

            subj1a.ExecuteNonQuery()
            subj1b.ExecuteNonQuery()
            subj1c.ExecuteNonQuery()

            subj2a.ExecuteNonQuery()
            subj2b.ExecuteNonQuery()
            subj2c.ExecuteNonQuery()

            subj3a.ExecuteNonQuery()
            subj3b.ExecuteNonQuery()
            subj3c.ExecuteNonQuery()

            subj4a.ExecuteNonQuery()
            subj4b.ExecuteNonQuery()
            subj4c.ExecuteNonQuery()


            subj5a.ExecuteNonQuery()
            subj5b.ExecuteNonQuery()
            subj5c.ExecuteNonQuery()

            subj6a.ExecuteNonQuery()
            subj6b.ExecuteNonQuery()
            subj6c.ExecuteNonQuery()



            subj7a.ExecuteNonQuery()
            subj7b.ExecuteNonQuery()
            subj7c.ExecuteNonQuery()


            subj8a.ExecuteNonQuery()
            subj8b.ExecuteNonQuery()
            subj8c.ExecuteNonQuery()


            subj9a.ExecuteNonQuery()
            subj9b.ExecuteNonQuery()
            subj9c.ExecuteNonQuery()

            subj10a.ExecuteNonQuery()
            subj10b.ExecuteNonQuery()
            subj10c.ExecuteNonQuery()

            subj10a.ExecuteNonQuery()
            subj10b.ExecuteNonQuery()
            subj10c.ExecuteNonQuery()


            subj11a.ExecuteNonQuery()
            subj11b.ExecuteNonQuery()
            subj11c.ExecuteNonQuery()

            subj12a.ExecuteNonQuery()
            subj12b.ExecuteNonQuery()
            subj12c.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Nursery Students Graded")


        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub GRADENURSERYPUPILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRADENURSERYPUPILSToolStripMenuItem.Click
        gradenusery()

    End Sub

    Private Sub txt_term_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_term.SelectedIndexChanged
        loadcompetences()
    End Sub
End Class