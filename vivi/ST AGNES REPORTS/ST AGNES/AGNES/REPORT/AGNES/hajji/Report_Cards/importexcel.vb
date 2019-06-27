Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class importexcel
    Private Excel03ConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"
    Private Excel07ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'"

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub importexcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
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
            MsgBox("Empty records found just go ahead and save !")

            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim con As New MySqlConnection(constring)

            Dim cmd As New MySqlCommand("INSERT INTO reportcards.students(Name,Class,Year,combination) VALUES(@Name,@Class,@Year,@Combination)", con)

            cmd.Parameters.AddWithValue("@Name", String.Empty)
            cmd.Parameters.AddWithValue("@Class", String.Empty)
            cmd.Parameters.AddWithValue("@Year", String.Empty)
            cmd.Parameters.AddWithValue("@Combination", String.Empty)



            For Each row As DataGridViewRow In dataGridView1.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters(0).Value =
                        If(row.Cells("Name").Value Is Nothing, DBNull.Value, row.Cells("Name").Value.ToString())

                    cmd.Parameters(1).Value =
                        If(Regstudents.txt_class.Text Is Nothing, DBNull.Value, Regstudents.txt_class.Text.ToString())

                    cmd.Parameters(2).Value =
                    If(Regstudents.txt_year.Text Is Nothing, DBNull.Value, Regstudents.txt_year.Text.ToString())

                    cmd.Parameters(3).Value =
                    If(Regstudents.txt_combination.Text Is Nothing, DBNull.Value, Regstudents.txt_combination.Text.ToString())

                    

                    ' Here Execute your query for each row
                    con.Open()
                    If cmd.ExecuteNonQuery() > 0 Then

                    End If
                    con.Close()
                End If
            Next
            MessageBox.Show("Students Imported")
        ElseIf IsDataGridViewEmpty(Me.dataGridView1) = False Then
            MsgBox(" No Empty records found just go ahead and save !")

            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim con As New MySqlConnection(constring)

            Dim cmd As New MySqlCommand("INSERT INTO reportcards.students(Name,Class,Year,combination) VALUES(@Name,@Class,@Year,@Combination)", con)

            cmd.Parameters.AddWithValue("@Name", String.Empty)
            cmd.Parameters.AddWithValue("@Class", String.Empty)
            cmd.Parameters.AddWithValue("@Year", String.Empty)
            cmd.Parameters.AddWithValue("@Combination", String.Empty)



            For Each row As DataGridViewRow In dataGridView1.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters(0).Value =
                        If(row.Cells("Name").Value Is Nothing, DBNull.Value, row.Cells("Name").Value.ToString())

                    cmd.Parameters(1).Value =
                        If(Regstudents.txt_class.Text Is Nothing, DBNull.Value, Regstudents.txt_class.Text.ToString())

                    cmd.Parameters(2).Value =
                    If(Regstudents.txt_year.Text Is Nothing, DBNull.Value, Regstudents.txt_year.Text.ToString())

                    cmd.Parameters(3).Value =
                    If(Regstudents.txt_combination.Text Is Nothing, DBNull.Value, Regstudents.txt_combination.Text.ToString())



                    ' Here Execute your query for each row
                    con.Open()
                    If cmd.ExecuteNonQuery() > 0 Then

                    End If
                    con.Close()
                End If
            Next
            MessageBox.Show("Students Imported")
        End If
    End Sub

    Public Sub saveimpotreddataintophototbl()
        Try
            For Each row As DataGridViewRow In dataGridView1.Rows
                Dim constring As String = "datasource=localhost;port=3306;username=root;"
                Dim con As New MySqlConnection(constring)
                Dim cmd As New MySqlCommand("INSERT INTO reportcards.photo(name,Occupation,Year) VALUES(@name,@Occupation,@Year)", con)
                cmd.Parameters.AddWithValue("@name", row.Cells("Name").Value)
                cmd.Parameters.AddWithValue("@Occupation", row.Cells("Occupation").Value)
                cmd.Parameters.AddWithValue("@Year", row.Cells("Year").Value)
               
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

            Next
            MessageBox.Show("Data inserted into Photos Table.")




        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        OpenFileDialog1.ShowDialog()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        saveimporteddataintostudentstbl()
        'saveimpotreddataintophototbl()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not dataGridView1.CurrentRow.IsNewRow Then
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow)
        End If
    End Sub

    Private Sub dataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGridView1.CellContentClick

    End Sub

    Private Sub rbHeaderYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbHeaderYes.CheckedChanged

    End Sub
End Class