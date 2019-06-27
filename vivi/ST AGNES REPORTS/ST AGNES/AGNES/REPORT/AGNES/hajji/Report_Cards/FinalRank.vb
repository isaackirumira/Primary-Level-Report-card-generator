Imports MySql.Data.MySqlClient
Public Class FinalRank
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

            setcomments()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        Try
            setcomments()


        Catch ex As Exception

        End Try
    End Sub
    Public Sub setcomments()
        Try



            Dim i2 As Integer
            i2 = DataGridView1.CurrentRow.Index

            If ((DataGridView1.Item(4, i2).Value >= 0) And (DataGridView1.Item(4, i2).Value <= 100)) Then

                DataGridView1.Item(5, i2).Value = "Please hard work is still needed for better results."
                DataGridView1.Item(6, i2).Value = "Consult your teachers more often for the best."
                automovecusor()

            ElseIf ((DataGridView1.Item(4, i2).Value > 100) And (DataGridView1.Item(4, i2).Value <= 200)) Then

                DataGridView1.Item(5, i2).Value = "Hard work is still needed."
                DataGridView1.Item(6, i2).Value = "Intensive Revision needed for better results."
                automovecusor()
            ElseIf ((DataGridView1.Item(4, i2).Value > 200) And (DataGridView1.Item(4, i2).Value <= 300)) Then

                DataGridView1.Item(5, i2).Value = "Performance is above average."
                DataGridView1.Item(6, i2).Value = "Do not relax you can get better results."
                automovecusor()

            ElseIf ((DataGridView1.Item(4, i2).Value > 300) And (DataGridView1.Item(4, i2).Value <= 400)) Then

                DataGridView1.Item(5, i2).Value = "Good results but do not relax if you need better results."
                DataGridView1.Item(6, i2).Value = "Promising results just put in more effort."
                automovecusor()

            ElseIf ((DataGridView1.Item(4, i2).Value > 400)) Then

                DataGridView1.Item(5, i2).Value = "Good results but do not relax if you need better results."
                DataGridView1.Item(6, i2).Value = "Promising results just put in more effort."
                automovecusor()

            End If
        Catch ex As Exception





        End Try

    End Sub
    Public Sub automovecusor()

        Try
            SendKeys.Send("{down}")

        Catch ex As Exception

        End Try

    End Sub

    Public Sub savetotals()

        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim constring As String = "datasource=localhost;port=3306;username=root;"
                Dim con As New MySqlConnection(constring)
                Dim cmd As New MySqlCommand("INSERT INTO reportcards.totals(name,class,term,year,TotalMark,CLASSTEACTHER,HEADTEACTHER) VALUES(@name,@class,@term,@year,@TotalMark,@CLASSTEACTHER,@HEADTEACTHER)", con)
                cmd.Parameters.AddWithValue("@name", row.Cells("name").Value)
                cmd.Parameters.AddWithValue("@class", row.Cells("Class").Value)
                cmd.Parameters.AddWithValue("@term", row.Cells("term").Value)
                cmd.Parameters.AddWithValue("@year", row.Cells("year").Value)
                cmd.Parameters.AddWithValue("@TotalMark", row.Cells("TotalMark").Value)

                cmd.Parameters.AddWithValue("@CLASSTEACTHER", row.Cells("CLASSTEACTHER").Value)
                cmd.Parameters.AddWithValue("@HEADTEACTHER", row.Cells("HEADTEACTHER").Value)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

            Next
            MessageBox.Show("Totals have been saved now make ranks.")



            'fill_data_grid()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Public Sub deletetotals()

        Try




            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from reportcards.totals where class='" + RecordMarks.txt_class.Text + "' and year='" + RecordMarks.txt_year.Text + "' and term='" + RecordMarks.txt_term.Text + "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()

            myReader = SelectCommand.ExecuteReader()




            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)




        End Try
    End Sub
    Public Sub deleteranks()

        Try




            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from reportcards.positions where class='" + RecordMarks.txt_class.Text + "' and year='" + RecordMarks.txt_year.Text + "' and term='" + RecordMarks.txt_term.Text + "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()

            myReader = SelectCommand.ExecuteReader()




            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)




        End Try
    End Sub
    Public Sub checktoseeifrankisdone()
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from reportcards.positions where class='" + RecordMarks.txt_class.Text + "' and year='" + RecordMarks.txt_year.Text + "' and term='" + RecordMarks.txt_term.Text + "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1

            End If


            If (count = 0) Then
                Savepositions()
            ElseIf (count > 0) Then
                updatepositions()

            End If


            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)


        End Try


    End Sub
    Public Sub updatepositions()
        deletetotals()
        deleteranks()
        savetotals()
        Savepositions()

    End Sub

    Public Sub Savepositions()
        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim constring As String = "datasource=localhost;port=3306;username=root;"
                Dim con As New MySqlConnection(constring)
                Dim cmd As New MySqlCommand("INSERT INTO reportcards.positions(name,class,term,year,TotalMark,position,CLASSTEACTHER,HEADTEACTHER) VALUES(@name,@class,@term,@year,@TotalMark,@position,@CLASSTEACTHER,@HEADTEACTHER)", con)
                cmd.Parameters.AddWithValue("@name", row.Cells("name").Value)
                cmd.Parameters.AddWithValue("@class", row.Cells("Class").Value)
                cmd.Parameters.AddWithValue("@term", row.Cells("term").Value)
                cmd.Parameters.AddWithValue("@year", row.Cells("year").Value)
                cmd.Parameters.AddWithValue("@TotalMark", row.Cells("TotalMark").Value)
                cmd.Parameters.AddWithValue("@position", row.Cells("Position").Value)
                cmd.Parameters.AddWithValue("@CLASSTEACTHER", row.Cells("CLASSTEACTHER").Value)
                cmd.Parameters.AddWithValue("@HEADTEACTHER", row.Cells("HEADTEACTHER").Value)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

            Next
            MessageBox.Show("Ranks Generated.")



            'fill_data_grid()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Testbest8_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (MessageBox.Show("Have you saved?", "Report card wizard", MessageBoxButtons.YesNo) = DialogResult.Yes) Then

        Else
            e.Cancel = True

        End If

    End Sub
    Private Sub FinalRank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("SELECT  distinct(name),class,term,year,TotalMark,CLASSTEACTHER,HEADTEACTHER, FIND_IN_SET(TotalMark, (SELECT GROUP_CONCAT(TotalMark  ORDER BY  TotalMark  DESC ) FROM reportcards.totals WHERE class='" + RecordMarks.txt_class.Text + "' and year='" + RecordMarks.txt_year.Text + "' and term='" + RecordMarks.txt_term.Text + "' )) AS Position FROM reportcards.totals where name in (SELECT distinct name from reportcards.totals) and class='" + RecordMarks.txt_class.Text + "' and year='" + RecordMarks.txt_year.Text + "' and term='" + RecordMarks.txt_term.Text + "' ORDER BY TotalMark DESC", conDatabase)
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
        setcomments()


    End Sub

    Private Sub FinallyRankStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        checktoseeifrankisdone()

    End Sub
End Class