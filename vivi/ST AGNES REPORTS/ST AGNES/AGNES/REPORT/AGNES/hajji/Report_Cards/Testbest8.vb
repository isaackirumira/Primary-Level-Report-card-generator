Imports MySql.Data.MySqlClient
Public Class Testbest8
    Dim Div1 As String = "ONE"
    Dim Div2 As String = "TWO"
    Dim Div3 As String = "THREE"
    Dim Div4 As String = "FOUR"
    Dim DivU As String = "U"
    Dim subjectEng = "English"
    Dim subjectMath = "MATHEMATICS"
    Dim subjectSCIENCE = "Science"
    Dim subjectSST = "SST"
    Dim subjectBiology = "BIOLOGY"

    Dim subjectChemisrty = "Chemistry"
    Dim subjectPhysics = "Physics"
    Dim AG = "9"
    Dim DivisionX = "X"
   
    Public Sub SENDTHOSEIN2AND3()

        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
            Dim con As New MySqlConnection(constring)

            Dim VMX As New MySqlCommand("update reportcards.MARKS set DIVI='" + Div2 + "' where ((Best8>12 and Best8<=20) AND AGGREGATE>8 AND (SUBJECT='" + subjectEng + "' OR SUBJECT='" + subjectMath + "' OR SUBJECT='" + subjectSCIENCE + "' OR SUBJECT='" + subjectSST + "' ))  ", con)



            Dim VM As New MySqlCommand("update reportcards.MARKS set DIVI='" + Div3 + "' where ((Best8>20 and Best8<=34) AND AGGREGATE>8 AND (SUBJECT='" + subjectEng + "' OR SUBJECT='" + subjectMath + "' OR SUBJECT='" + subjectSCIENCE + "' OR SUBJECT='" + subjectSST + "' ))  ", con)


            Dim NM As New MySqlCommand("update reportcards.MARKS set DIVI='" + Div4 + "' where  ((Best8>34 and Best8<=36) AND AGGREGATE>8 AND (SUBJECT='" + subjectEng + "' OR SUBJECT='" + subjectMath + "' OR SUBJECT='" + subjectSCIENCE + "' OR SUBJECT='" + subjectSST + "' ))  ", con)


            con.Open()

            VMX.ExecuteNonQuery()
            VM.ExecuteNonQuery()

            NM.ExecuteNonQuery()

            con.Close()

            MessageBox.Show("DIVISION TRAVERSAL DONE")
            


        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub initialisegrade()

        getaggregateeng()

        setXDIVISION()
        setXDIVISIONAGGLESSTHAN8()

    End Sub

    Public Sub setXDIVISION()
        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
            Dim con As New MySqlConnection(constring)

            'div
            Dim cmdDIV1XX As New MySqlCommand("update reportcards.MARKS set DIVI='" + DivisionX + "' WHERE Best8='0'", con)

            con.Open()
            cmdDIV1XX.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception

        End Try
    End Sub
    Public Sub setXDIVISIONAGGLESSTHAN8()
        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
            Dim con As New MySqlConnection(constring)

            'div
            Dim cmdDIV1XX As New MySqlCommand("update reportcards.MARKS set DIVI='" + DivisionX + "' WHERE Best8<4", con)

            con.Open()
            cmdDIV1XX.ExecuteNonQuery()

            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub getaggregateeng()

        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
            Dim con As New MySqlConnection(constring)

            'div
            Dim cmdDIV1 As New MySqlCommand("update reportcards.MARKS set DIVI='" + Div1 + "' where  ((Best8>=0 and Best8<=12) AND AGGREGATE<9 AND (SUBJECT='" + subjectEng + "' OR SUBJECT='" + subjectMath + "' OR SUBJECT='" + subjectSCIENCE + "' OR SUBJECT='" + subjectSST + "' )) ", con)


            Dim cmdDIV12 As New MySqlCommand("update reportcards.MARKS set DIVI='" + Div2 + "' where ((Best8>13 and Best8<=24) AND AGGREGATE<9 AND (SUBJECT='" + subjectEng + "' OR SUBJECT='" + subjectMath + "' OR SUBJECT='" + subjectSCIENCE + "' OR SUBJECT='" + subjectSST + "' )) ", con)
            


            Dim cmdDIV13 As New MySqlCommand("update reportcards.MARKS set DIVI='" + Div3 + "' where  ((Best8>25 and Best8<=33) AND AGGREGATE<9 AND AGGREGATE<9 AND (SUBJECT='" + subjectEng + "' OR SUBJECT='" + subjectMath + "' OR SUBJECT='" + subjectSCIENCE + "' OR SUBJECT='" + subjectSST + "' )) ", con)
           
            Dim cmdDIV4 As New MySqlCommand("update reportcards.MARKS set DIVI='" + Div4 + "' where (Best8>34 and Best8<=35 ) AND AGGREGATE<9 AND (SUBJECT='" + subjectEng + "' OR SUBJECT='" + subjectMath + "' OR SUBJECT='" + subjectSCIENCE + "' OR SUBJECT='" + subjectSST + "' ))  ", con)

            Dim cmdDIV41 As New MySqlCommand("update reportcards.MARKS set DIVI='" + DivU + "' where (Best8>34 and Best8<=35 ) AND AGGREGATE>8 AND (SUBJECT='" + subjectEng + "' OR SUBJECT='" + subjectMath + "' OR SUBJECT='" + subjectSCIENCE + "' OR SUBJECT='" + subjectSST + "' ))  ", con)

            Dim cmdDIVU As New MySqlCommand("update reportcards.MARKS set DIVI='" + DivU + "' where (Best8>35 ) ", con)



            con.Open()
            cmdDIV1.ExecuteNonQuery()

            cmdDIV12.ExecuteNonQuery()

            cmdDIV13.ExecuteNonQuery()

            cmdDIV4.ExecuteNonQuery()

            cmdDIV41.ExecuteNonQuery()
            cmdDIVU.ExecuteNonQuery()

            cmdDIV1.ExecuteNonQuery()
            cmdDIV12.ExecuteNonQuery()


          


            con.Close()

            MessageBox.Show("Divisions updated")


        Catch ex As Exception

            'MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub fillcount()
        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("SELECT count(aggregate) as Subjects  FROM reportcards.marks WHERE term = '" + RecordMarks.txt_term.Text + "' AND year = '" + RecordMarks.txt_year.Text + "' and class='" + RecordMarks.txt_class.Text + "' AND AGGREGATE BETWEEN 1 AND 9 GROUP BY NAME  ", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            DataGridView7.DataSource = bSource
            sda.Update(dbDataset)
            conDatabase.Close()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub selectbiology()
        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("SELECT aggregate as Biology from reportcards.grades WHERE subject='" + subjectBiology + "' and class='" + RecordMarks.txt_class.Text + "' and term='" + RecordMarks.txt_term.Text + "' and year='" + RecordMarks.txt_year.Text + "'   GROUP BY name  ", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            DataGridView6.DataSource = bSource
            sda.Update(dbDataset)
            conDatabase.Close()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub selectchemistry()
        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("SELECT aggregate as Chemistry from reportcards.grades WHERE subject='" + subjectChemisrty + "' and class='" + RecordMarks.txt_class.Text + "' and term='" + RecordMarks.txt_term.Text + "' and year='" + RecordMarks.txt_year.Text + "'   GROUP BY name  ", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            DataGridView5.DataSource = bSource
            sda.Update(dbDataset)
            conDatabase.Close()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub selectphysics()
        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("SELECT aggregate as Physics from reportcards.grades WHERE subject='" + subjectPhysics + "' and class='" + RecordMarks.txt_class.Text + "' and term='" + RecordMarks.txt_term.Text + "' and year='" + RecordMarks.txt_year.Text + "'   GROUP BY name  ", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            DataGridView4.DataSource = bSource
            sda.Update(dbDataset)
            conDatabase.Close()

        Catch ex As Exception

        End Try
    End Sub
    Public Sub selectmath()
        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("SELECT aggregate as Math from reportcards.marks WHERE subject='" + subjectMath + "' and class='" + RecordMarks.txt_class.Text + "' and term='" + RecordMarks.txt_term.Text + "' and year='" + RecordMarks.txt_year.Text + "'   GROUP BY name ", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            DataGridView3.DataSource = bSource
            sda.Update(dbDataset)
            conDatabase.Close()

        Catch ex As Exception

        End Try
    End Sub
    Public Sub selecteng()
        Try

            Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("SELECT aggregate as English from reportcards.marks WHERE subject='" + subjectEng + "' and class='" + RecordMarks.txt_class.Text + "' and term='" + RecordMarks.txt_term.Text + "' and year='" + RecordMarks.txt_year.Text + "'   GROUP BY name  ", conDatabase)
            Dim sda As MySqlDataAdapter = New MySqlDataAdapter()
            sda.SelectCommand = cmdDatabase
            Dim dbDataset As DataTable = New DataTable()
            sda.Fill(dbDataset)
            Dim bSource As BindingSource = New BindingSource()
            bSource.DataSource = dbDataset
            DataGridView2.DataSource = bSource
            sda.Update(dbDataset)
            conDatabase.Close()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub updatediv()
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows

                Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
                Dim con As New MySqlConnection(constring)
                Dim cmd As New MySqlCommand("INSERT INTO reportcards.best8(DIVI,Name,Class,Term,Year,Best_Eight_AGGREGATES) VALUES(@DIVI,@name,@class,@term,@year,@best8)", con)

                cmd.Parameters.AddWithValue("@DIVI", row.Cells("DIVI").Value)
                cmd.Parameters.AddWithValue("@name", row.Cells("Name").Value)
                cmd.Parameters.AddWithValue("@class", row.Cells("Class").Value)
                cmd.Parameters.AddWithValue("@term", row.Cells("Term").Value)
                cmd.Parameters.AddWithValue("@year", row.Cells("Year").Value)
                cmd.Parameters.AddWithValue("@best8", row.Cells("Best_Eight").Value)


                con.Open()
                cmd.ExecuteNonQuery()

                con.Close()

            Next

            MessageBox.Show("Best 8 Ranks Generated And Save To Database.")

        Catch ex As Exception

        End Try
    End Sub

    Public Sub setfinaldivisions()
        Try



            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index
            For Each row As DataGridViewRow In DataGridView1.Rows

                If ((DataGridView1.Item(5, i2).Value = 0)) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If

                If ((DataGridView2.Item(0, i2).Value = "0")) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If
                If ((DataGridView3.Item(0, i2).Value = "0")) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If
                'setting subjects less than 8 
                If ((DataGridView1.Item(6, i2).Value < 8)) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If


                If ((DataGridView1.Item(6, i2).Value > 8) And (DataGridView2.Item(0, i2).Value = 0 Or DataGridView3.Item(0, i2).Value = 0)) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) >= 8 And (DataGridView1.Item(5, i2).Value) <= 32 And (DataGridView2.Item(0, i2).Value < 7 And DataGridView3.Item(0, i2).Value < 7)) Then

                    DataGridView1.Item(0, i2).Value = Div1
                    automovecusor()
                End If

                If ((DataGridView1.Item(5, i2).Value) >= 8 And (DataGridView1.Item(5, i2).Value) <= 32 And (DataGridView2.Item(0, i2).Value > 6)) Then

                    DataGridView1.Item(0, i2).Value = Div2
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) >= 8 And (DataGridView1.Item(5, i2).Value) <= 32 And (DataGridView3.Item(0, i2).Value > 6)) Then

                    DataGridView1.Item(0, i2).Value = Div2
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) >= 8 And (DataGridView1.Item(5, i2).Value) <= 32 And (DataGridView3.Item(0, i2).Value = "0")) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) >= 8 And (DataGridView1.Item(5, i2).Value) <= 32 And (DataGridView2.Item(0, i2).Value = "0")) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                    ''''
                End If
                If ((DataGridView1.Item(5, i2).Value) > 32 And (DataGridView1.Item(5, i2).Value) <= 49 And (DataGridView2.Item(0, i2).Value < 7 And DataGridView3.Item(0, i2).Value < 7)) Then

                    DataGridView1.Item(0, i2).Value = Div2
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) > 32 And (DataGridView1.Item(5, i2).Value) <= 49 And (DataGridView2.Item(0, i2).Value > 6)) Then

                    DataGridView1.Item(0, i2).Value = Div3
                    automovecusor()
                End If

                If ((DataGridView1.Item(5, i2).Value) > 32 And (DataGridView1.Item(5, i2).Value) <= 49 And (DataGridView3.Item(0, i2).Value > 6)) Then

                    DataGridView1.Item(0, i2).Value = Div3
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) >= 32 And (DataGridView1.Item(5, i2).Value) <= 49 And (DataGridView3.Item(0, i2).Value = "0")) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) >= 32 And (DataGridView1.Item(5, i2).Value) <= 49 And (DataGridView2.Item(0, i2).Value = "0")) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If
                '''''
                If ((DataGridView1.Item(5, i2).Value) > 49 And (DataGridView1.Item(5, i2).Value) <= 54 And (DataGridView2.Item(0, i2).Value < 7 And DataGridView3.Item(0, i2).Value < 7)) Then

                    DataGridView1.Item(0, i2).Value = Div3
                    automovecusor()
                End If


                If ((DataGridView1.Item(5, i2).Value) > 49 And (DataGridView1.Item(5, i2).Value) <= 54 And (DataGridView2.Item(0, i2).Value > 6)) Then

                    DataGridView1.Item(0, i2).Value = Div4
                    automovecusor()
                End If


                If ((DataGridView1.Item(5, i2).Value) > 49 And (DataGridView1.Item(5, i2).Value) <= 54 And (DataGridView3.Item(0, i2).Value > 6)) Then

                    DataGridView1.Item(0, i2).Value = Div4
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) >= 49 And (DataGridView1.Item(5, i2).Value) <= 54 And (DataGridView3.Item(0, i2).Value = "0")) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) >= 49 And (DataGridView1.Item(5, i2).Value) <= 54 And (DataGridView2.Item(0, i2).Value = "0")) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If
                ''''''

                If ((DataGridView1.Item(5, i2).Value) > 54 And (DataGridView1.Item(5, i2).Value) <= 68) Then

                    DataGridView1.Item(0, i2).Value = Div4
                    automovecusor()
                End If


                If ((DataGridView1.Item(5, i2).Value) >= 54 And (DataGridView1.Item(5, i2).Value) <= 68 And (DataGridView3.Item(0, i2).Value = "0")) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) >= 54 And (DataGridView1.Item(5, i2).Value) <= 68 And (DataGridView2.Item(0, i2).Value = "0")) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) > 68 And (DataGridView1.Item(5, i2).Value) <= 72) Then

                    DataGridView1.Item(0, i2).Value = DivU
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) >= 68 And (DataGridView1.Item(5, i2).Value) <= 72 And (DataGridView3.Item(0, i2).Value = "0")) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()
                End If
                If ((DataGridView1.Item(5, i2).Value) >= 68 And (DataGridView1.Item(5, i2).Value) <= 72 And (DataGridView2.Item(0, i2).Value = "0")) Then

                    DataGridView1.Item(0, i2).Value = "X"
                    automovecusor()


                End If
            Next

        Catch ex As Exception

        End Try

    End Sub



    Public Sub deletebest8()

        Try




            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from reportcards.best8 where class='" + RecordMarks.txt_class.Text + "' and year='" + RecordMarks.txt_year.Text + "' and term='" + RecordMarks.txt_term.Text + "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()

            myReader = SelectCommand.ExecuteReader()




            mycon.Close()


        Catch ex As Exception





        End Try
    End Sub
    Public Sub checktoseeiftemporalbest8isdone()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.best8 where class='" + RecordMarks.txt_class.Text + "' and year='" + RecordMarks.txt_year.Text + "' and term='" + RecordMarks.txt_term.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1

            End If


            If (count = 0) Then
                updatediv()
            ElseIf (count > 0) Then

                deletebest8()
                updatediv()

            End If


            mycon.Close()


        Catch ex As Exception



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



        End Try
    End Sub


    Private Sub DataGridView1_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        Try
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)


            setfinaldivisions()


        Catch ex As Exception



        End Try
    End Sub

    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        Try


            setfinaldivisions()


        Catch ex As Exception



        End Try
    End Sub


    Public Sub automovecusor()

        Try

            SendKeys.Send("{down}")


        Catch ex As Exception



        End Try



    End Sub




    Public Sub getbesteightaggregates()
        Try


            Dim constring As String = "datasource=localhost;port=3306;username=root;allowuservariables=True;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("SELECT DIVI,Name,Class,Term,Year,best8 As Best_Eight,count(aggregate) as subjects  FROM reportcards.marks WHERE  class='" + RecordMarks.txt_class.Text + "' and term='" + RecordMarks.txt_term.Text + "' and year='" + RecordMarks.txt_year.Text + "' AND AGGREGATE BETWEEN 1 AND 9    GROUP BY name ", conDatabase)

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

        End Try

    End Sub
    Public Sub autosave()
        Try
            checktoseeiftemporalbest8isdone()
        Catch ex As Exception



        End Try
    End Sub
    Private Sub Testbest8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        getaggregateeng()

        setXDIVISION()
        setXDIVISIONAGGLESSTHAN8()
        'setfinaldivisions()
        Try
            DataGridView1.ForeColor = Color.Blue
            DataGridView7.ForeColor = Color.Blue

            DataGridView2.ForeColor = Color.Red

            DataGridView3.ForeColor = Color.Red



            selectmath()
            selecteng()
            fillcount()
            'selectbiology()
            'selectchemistry()
            'selectphysics()
            getbesteightaggregates()






        Catch ex As Exception



        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub SAVEDIVISIONSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEDIVISIONSToolStripMenuItem.Click
        Try
            checktoseeiftemporalbest8isdone()
        Catch ex As Exception



        End Try
    End Sub

    Private Sub MenuStrip2_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub

    Private Sub Testbest8_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub


    Private Sub UPDATToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATToolStripMenuItem.Click
        UpdateDivision.Show()
    End Sub

    Private Sub DataGridView7_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    

    Private Sub TRAVERSEDIVISIONSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRAVERSEDIVISIONSToolStripMenuItem.Click

        SENDTHOSEIN2AND3()
    End Sub
End Class

