Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class IMPORTALEVELMARKS
    Private Excel03ConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
    Private Excel07ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
    Public Function IsDataGridViewEmpty(ByRef dataGridView1 As DataGridView) As Boolean
        Dim isEmpty As Boolean
        isEmpty = False
        For Each row As DataGridViewRow In dataGridView1.Rows
            For Each cell As DataGridViewCell In row.Cells
                If Not String.IsNullOrEmpty(cell.Value.ToString()) Then

                    If Not String.IsNullOrEmpty(Trim(cell.Value.ToString())) = True Then
                        Dim d = Trim(cell.Value.ToString())

                        isEmpty = False

                    End If
                Else
                    isEmpty = True
                    Exit For
                End If
            Next
        Next
        Return isEmpty
    End Function
    Public Sub saveimporteddataintostudentstbl()
        If IsDataGridViewEmpty(Me.dataGridView1) = True Then
            MsgBox("Students Found with out Marks, They will be saved with no marks !")

            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim con As New MySqlConnection(constring)

            Dim cmd As New MySqlCommand("INSERT INTO reportcards.aleveltotalpoints(P1MID,P2MID,P3MID,P4MID,Name,Class,Subject,Term,Year) VALUES(@PAPER1,@PAPER2,@PAPER3,@PAPER4,@Name,@Class,@Subject,@Term,@Year)", con)
            cmd.Parameters.AddWithValue("@PAPER1", String.Empty)
            cmd.Parameters.AddWithValue("@PAPER2", String.Empty)
            cmd.Parameters.AddWithValue("@PAPER3", String.Empty)
            cmd.Parameters.AddWithValue("@PAPER4", String.Empty)

            cmd.Parameters.AddWithValue("@Name", String.Empty)
            cmd.Parameters.AddWithValue("@Class", String.Empty)
            cmd.Parameters.AddWithValue("@subject", String.Empty)
            cmd.Parameters.AddWithValue("@Term", String.Empty)
            cmd.Parameters.AddWithValue("@Year", String.Empty)

            For Each row As DataGridViewRow In dataGridView1.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters(0).Value =
                        If(row.Cells("PAPER1").Value Is Nothing, DBNull.Value, row.Cells("PAPER1").Value.ToString())

                    cmd.Parameters(1).Value =
                        If(row.Cells("PAPER2").Value Is Nothing, DBNull.Value, row.Cells("PAPER2").Value.ToString())

                    cmd.Parameters(2).Value =
                        If(row.Cells("PAPER3").Value Is Nothing, DBNull.Value, row.Cells("PAPER3").Value.ToString())

                    cmd.Parameters(3).Value =
                        If(row.Cells("PAPER4").Value Is Nothing, DBNull.Value, row.Cells("PAPER4").Value.ToString())



                    cmd.Parameters(4).Value =
                        If(row.Cells("Name").Value Is Nothing, DBNull.Value, row.Cells("Name").Value.ToString())

                    cmd.Parameters(5).Value =
                        If(RecordMarks.txt_class.Text Is Nothing, DBNull.Value, RecordMarksALevel.txt_class.Text.ToString())

                    cmd.Parameters(6).Value =
                    If(RecordMarks.txt_subject.Text Is Nothing, DBNull.Value, RecordMarksALevel.txt_subject.Text.ToString())

                    cmd.Parameters(7).Value =
                    If(RecordMarks.txt_term.Text Is Nothing, DBNull.Value, RecordMarksALevel.txt_term.Text.ToString())

                    cmd.Parameters(8).Value =
                     If(RecordMarks.txt_year.Text Is Nothing, DBNull.Value, RecordMarksALevel.txt_year.Text.ToString())

                    ' Here Execute your query for each row
                    con.Open()
                    If cmd.ExecuteNonQuery() > 0 Then

                    End If
                    con.Close()
                End If
            Next
            MessageBox.Show("Marks Imported")

        ElseIf IsDataGridViewEmpty(Me.dataGridView1) = False Then
            MsgBox("No Students Found with out Marks, They will be saved with no marks !")

            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim con As New MySqlConnection(constring)

            Dim cmd As New MySqlCommand("INSERT INTO reportcards.aleveltotalpoints(P1MID,P2MID,P3MID,P4MID,Name,Class,Subject,Term,Year) VALUES(@PAPER1,@PAPER2,@PAPER3,@PAPER4,@Name,@Class,@Subject,@Term,@Year)", con)
            cmd.Parameters.AddWithValue("@PAPER1", String.Empty)
            cmd.Parameters.AddWithValue("@PAPER2", String.Empty)
            cmd.Parameters.AddWithValue("@PAPER3", String.Empty)
            cmd.Parameters.AddWithValue("@PAPER4", String.Empty)

            cmd.Parameters.AddWithValue("@Name", String.Empty)
            cmd.Parameters.AddWithValue("@Class", String.Empty)
            cmd.Parameters.AddWithValue("@subject", String.Empty)
            cmd.Parameters.AddWithValue("@Term", String.Empty)
            cmd.Parameters.AddWithValue("@Year", String.Empty)

            For Each row As DataGridViewRow In dataGridView1.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters(0).Value =
                        If(row.Cells("PAPER1").Value Is Nothing, DBNull.Value, row.Cells("PAPER1").Value.ToString())

                    cmd.Parameters(1).Value =
                        If(row.Cells("PAPER2").Value Is Nothing, DBNull.Value, row.Cells("PAPER2").Value.ToString())

                    cmd.Parameters(2).Value =
                        If(row.Cells("PAPER3").Value Is Nothing, DBNull.Value, row.Cells("PAPER3").Value.ToString())

                    cmd.Parameters(3).Value =
                        If(row.Cells("PAPER4").Value Is Nothing, DBNull.Value, row.Cells("PAPER4").Value.ToString())



                    cmd.Parameters(4).Value =
                        If(row.Cells("Name").Value Is Nothing, DBNull.Value, row.Cells("Name").Value.ToString())

                    cmd.Parameters(5).Value =
                        If(RecordMarks.txt_class.Text Is Nothing, DBNull.Value, RecordMarksALevel.txt_class.Text.ToString())

                    cmd.Parameters(6).Value =
                    If(RecordMarks.txt_subject.Text Is Nothing, DBNull.Value, RecordMarksALevel.txt_subject.Text.ToString())

                    cmd.Parameters(7).Value =
                    If(RecordMarks.txt_term.Text Is Nothing, DBNull.Value, RecordMarksALevel.txt_term.Text.ToString())

                    cmd.Parameters(8).Value =
                     If(RecordMarks.txt_year.Text Is Nothing, DBNull.Value, RecordMarksALevel.txt_year.Text.ToString())

                    ' Here Execute your query for each row
                    con.Open()
                    If cmd.ExecuteNonQuery() > 0 Then

                    End If
                    con.Close()
                End If
            Next
            MessageBox.Show("Marks Imported")
        End If
    End Sub
    Private Sub openFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Try
            Dim filePath As String = OpenFileDialog1.FileName
            Dim extension As String = Path.GetExtension(filePath)
            Dim header As String = If(rbHeaderYes.Checked, "YES", "NO")
            Dim conStr As String, sheetName As String

            conStr = String.Empty
            Select Case extension

                Case ".xls"
                    'Excel 97-03
                    conStr = String.Format(Excel03ConString, filePath, header)
                    Exit Select

                Case ".xlsx"
                    'Excel 07
                    conStr = String.Format(Excel07ConString, filePath, header)
                    Exit Select
            End Select

            'Get the name of the First Sheet.
            Using con As New OleDbConnection(conStr)
                Using cmd As New OleDbCommand()
                    cmd.Connection = con
                    con.Open()
                    Dim dtExcelSchema As DataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
                    sheetName = dtExcelSchema.Rows(0)("TABLE_NAME").ToString()
                    con.Close()
                End Using
            End Using

            'Read Data from the First Sheet.
            Using con As New OleDbConnection(conStr)
                Using cmd As New OleDbCommand()
                    Using oda As New OleDbDataAdapter()
                        Dim dt As New DataTable()
                        cmd.CommandText = (Convert.ToString("SELECT * From [") & sheetName) + "]"
                        cmd.Connection = con
                        con.Open()
                        oda.SelectCommand = cmd
                        oda.Fill(dt)
                        con.Close()

                        'Populate DataGridView.
                        dataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not dataGridView1.CurrentRow.IsNewRow Then
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        saveimporteddataintostudentstbl()
    End Sub

    Private Sub IMPORTALEVELMARKS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class