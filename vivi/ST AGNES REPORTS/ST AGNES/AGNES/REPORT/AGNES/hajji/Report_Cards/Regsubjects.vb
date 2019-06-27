Imports MySql.Data.MySqlClient
Public Class Regsubjects
   
    Public Sub delolevel()
        Dim Aa As String

        Aa = MsgBox("are you sure u want to delete?", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_level.Text.Length > 0) Then

                Try




                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from reportcards.subjects where id='" + txt_id.Text + "' ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Data has been deleted")

                    fill_data_grid()


                    txt_subject.Text = ""
                    txt_id.Text = ""
                    txt_code.Text = ""
                   
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
    Public Sub UPDATEolevel()
        Dim Aa As String

        Aa = MsgBox("are you sure u want to update?", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_level.Text.Length > 0) Then

                Try




                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("update reportcards.subjects set subject='" & txt_subject.Text & "',code='" + txt_code.Text + "' where id='" + txt_id.Text + "'", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Data has been updated")

                    fill_data_grid()


                    txt_subject.Text = ""
                    txt_id.Text = ""
                    txt_code.Text = ""
                  
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
  
    Public Sub saveolevel()
        Dim Aa As String

        Aa = MsgBox("are you sure u want to save?", vbYesNo, "Question")

        If Aa = vbYes Then

            If (txt_level.Text.Length > 0) Then

                Try




                    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                    Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                    Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into reportcards.subjects(subject,code) values('" & txt_subject.Text & "','" + txt_code.Text + "') ", mycon)
                    Dim myReader As MySqlDataReader

                    mycon.Open()

                    myReader = SelectCommand.ExecuteReader()
                    MessageBox.Show("Data has been saved")

                    fill_data_grid()
                   
                    txt_subject.Text = ""
                    txt_id.Text = ""
                    txt_code.Text = ""

                    
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
  

    Public Sub fill_data_grid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select * from reportcards.subjects ;", conDatabase)
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Me.txt_id.Text = DataGridView1.Item(0, i).Value
        Me.txt_subject.Text = DataGridView1.Item(1, i).Value
        Me.txt_code.Text = DataGridView1.Item(2, i).Value
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If (txt_level.Text.Length > 0) Then
            If (txt_level.Text = "PRIMARY") Then
                saveolevel()
            
            End If
        Else
            MessageBox.Show("fill level")
        End If
    End Sub

    Private Sub Regsubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_data_grid()
        'fill_data_grid2()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        If (txt_level.Text.Length > 0) Then
            If (txt_level.Text = "PRIMARY") Then
                UPDATEolevel()
            
            End If
        Else
            MessageBox.Show("fill level")
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If (txt_level.Text.Length > 0) Then
            If (txt_level.Text = "PRIMARY") Then
                delolevel()
           
            End If
        Else
            MessageBox.Show("fill level")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ADDCOMPETENCESTOSUBJECTSLEARNINGAREASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADDCOMPETENCESTOSUBJECTSLEARNINGAREASToolStripMenuItem.Click
        COMPETENCES.Show()

    End Sub
End Class