
Imports MySql.Data.MySqlClient.MySqlDbType
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form3
    Dim myReader As MySqlDataReader
    Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
    Dim con As MySqlConnection = New MySqlConnection(myConnection)
    Dim count As Integer
    Dim cmd As MySqlCommand
    Dim PicutureBox1 As PictureBox
    Public Sub updateimage()

        Try
            If txt_fname.Text = "" And txt_sname.Text = "" Then
                MsgBox("Fill Students Name Fields")
            Else
                Dim cmd As New MySqlCommand("update school_payments.photos set imagename=@name,image=@photo where imagename=@name", con)
                cmd.Parameters.AddWithValue("@name", txt_fname.Text & " " & txt_sname.Text & " " & txt_oname.Text)
                Dim ms As New MemoryStream()
                PictureBox1.BackgroundImage.Save(ms, PictureBox1.BackgroundImage.RawFormat)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New MySqlParameter("@photo", MySqlDbType.Blob)
                p.Value = data
                cmd.Parameters.Add(p)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Updated", "photo", MessageBoxButtons.OK)


                PictureBox1.Image = Nothing

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)




        End Try
    End Sub

    Public Sub deletephoto()

        Try
            If txt_fname.Text = "" And txt_sname.Text = "" Then
                MsgBox("Fill Students Name Fields")
            Else
                Dim cmd As New MySqlCommand("delete from school_payments.photos where imagename=@name", con)
                cmd.Parameters.AddWithValue("@name", txt_fname.Text & " " & txt_sname.Text & " " & txt_oname.Text)


                cmd.ExecuteNonQuery()

                MessageBox.Show("Image", "deleted", MessageBoxButtons.OK)


                PictureBox1.Image = Nothing

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)




        End Try
    End Sub
    Public Sub Savephoto()
        Try
            If txt_fname.Text = "" And txt_sname.Text = "" Then
                MsgBox("Fill Students Name Fields")
            Else
                Dim cmd As New MySqlCommand("INSERT INTO school_payments.photos(imagename,image) VALUES(@name,@photo)", con)
                cmd.Parameters.AddWithValue("@name", txt_fname.Text & " " & txt_sname.Text & " " & txt_oname.Text)
                Dim ms As New MemoryStream()
                PictureBox1.BackgroundImage.Save(ms, PictureBox1.BackgroundImage.RawFormat)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New MySqlParameter("@photo", MySqlDbType.Blob)
                p.Value = data
                cmd.Parameters.Add(p)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Name & Image has been saved", "Save", MessageBoxButtons.OK)


                PictureBox1.Image = Nothing

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)




        End Try
    End Sub
    Public Sub fill_image()

        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim adptr As MySqlDataAdapter = New MySqlDataAdapter("select image from school_payments.photos where imagename= '" & txt_fname.Text & " " & txt_sname.Text & " " & txt_oname.Text & "'", mycon)
            Dim cmd As MySqlCommandBuilder = New MySqlCommandBuilder
            Dim dt As DataTable = New DataTable
            adptr.Fill(dt)
            Dim lb() As Byte = dt.Rows(0).Item("image")
            Dim lstr As New System.IO.MemoryStream(lb)
            PictureBox1.Image = Image.FromStream(lstr)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            lstr.Close()


        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
        End Try


    End Sub
    Public Sub fill_data_grid()
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select id,fname as Name,date,parent,telephone,sex,address,class,year,term,cond from school_payments.registration ;", conDatabase)
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
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_fname.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Then
            e.Handled = True
            MessageBox.Show("you can not enter numbers in this field please")
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_sname.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Then
            e.Handled = True
            MessageBox.Show("you can not enter numbers in this field please")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_oname.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Then
            e.Handled = True
            MessageBox.Show("you can not enter numbers in this field please")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_parent.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Then
            e.Handled = True
            MessageBox.Show("you can not enter numbers in this field please")
        End If
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        Form2.Visible = False
        Form1.Show()
    End Sub



    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fill_data_grid()
        con.Open()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Me.txt_id.Text = DataGridView1.Item(0, i).Value
        Me.txt_fname.Text = DataGridView1.Item(1, i).Value
        'Me.DateTimePicker1.Text = DataGridView1.Item(2, i).Value
        Me.txt_parent.Text = DataGridView1.Item(3, i).Value
        Me.txt_telephone.Text = DataGridView1.Item(4, i).Value
        Me.txt_sex.Text = DataGridView1.Item(5, i).Value
        Me.txt_address.Text = DataGridView1.Item(6, i).Value
        Me.txt_class.Text = DataGridView1.Item(7, i).Value
        Me.txt_year.Text = DataGridView1.Item(8, i).Value
        Me.txt_term.Text = DataGridView1.Item(9, i).Value
        Me.txt_condition.Text = DataGridView1.Item(10, i).Value





        fill_image()


    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATEToolStripMenuItem.Click
        If (txt_fname.Text.Length > 0 And txt_year.Text.Length > 0 And txt_term.Text.Length > 0 And txt_parent.Text.Length > 0 And txt_address.Text.Length > 0 And txt_telephone.Text.Length > 0 And txt_sex.Text.Length > 0) Then
            Try



                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("update school_payments.registration set fname='" & txt_fname.Text & "',date='" & DateTimePicker1.Text & "',parent='" & txt_parent.Text & "',telephone='" & txt_telephone.Text & "',sex='" & txt_sex.Text & "',address='" & txt_address.Text & "',class='" & txt_class.Text & "',year='" & txt_year.Text & "',term='" & txt_term.Text & "',cond='" + txt_condition.Text + "' where id='" & txt_id.Text & "' ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                updateimage()
                MessageBox.Show("Data has been updated")
                fill_data_grid()
                txt_address.Text = ""
                txt_condition.Text = ""
                txt_class.Text = ""
                txt_fname.Text = ""
                txt_id.Text = ""

                txt_oname.Text = ""
                txt_parent.Text = ""


                txt_telephone.Text = ""
                txt_year.Text = ""
                txt_term.Text = ""
                txt_sname.Text = ""


                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETEToolStripMenuItem.Click
        If (txt_fname.Text.Length > 0 And txt_year.Text.Length > 0 And txt_term.Text.Length > 0 And txt_parent.Text.Length > 0 And txt_address.Text.Length > 0 And txt_telephone.Text.Length > 0 And txt_sex.Text.Length > 0) Then
            Try



                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("delete from school_payments.registration  where id='" & txt_id.Text & "' ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()
                deletephoto()
                MessageBox.Show("Data has been deleted")
                fill_data_grid()
                txt_address.Text = ""
                txt_class.Text = ""
                txt_fname.Text = ""
                txt_id.Text = ""

                txt_oname.Text = ""
                txt_parent.Text = ""


                txt_telephone.Text = ""
                txt_year.Text = ""
                txt_term.Text = ""
                txt_sname.Text = ""


                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If
    End Sub

    Private Sub REPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTToolStripMenuItem.Click
        Registered_students.Show()
    End Sub

    Private Sub SEARCHBYNAMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCHBYNAMEToolStripMenuItem.Click
        Try
            Dim constring As String = "datasource=localhost;port=3306;username=root;"
            Dim conDatabase As MySqlConnection = New MySqlConnection(constring)
            Dim cmdDatabase As MySqlCommand = New MySqlCommand("Select id,fname as Name,date,parent,telephone,sex,address,class,year,term,cond  from school_payments.registration WHERE fname='" + txt_fname.Text + "' ;", conDatabase)
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

    Private Sub CToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click
        CrystalReport9.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEToolStripMenuItem1.Click

        If (txt_fname.Text.Length > 0 And txt_year.Text.Length > 0 And txt_term.Text.Length > 0 And txt_parent.Text.Length > 0 And txt_address.Text.Length > 0 And txt_telephone.Text.Length > 0 And txt_sex.Text.Length > 0) Then
            Try




                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into school_payments.registration(fname,date,parent,telephone,sex,address,class,year,term,cond) values('" & txt_fname.Text & "','" & DateTimePicker1.Text & "','" & txt_parent.Text & "','" & txt_telephone.Text & "','" & txt_sex.Text & "','" & txt_address.Text & "','" & txt_class.Text & "','" & txt_year.Text & "','" & txt_term.Text & "','" + txt_condition.Text + "') ", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()

                myReader = SelectCommand.ExecuteReader()

                Savephoto()
                MessageBox.Show("Data has been saved")
                fill_data_grid()
                txt_address.Text = ""
                txt_condition.Text = ""
                txt_class.Text = ""
                txt_fname.Text = ""
                txt_id.Text = ""

                txt_oname.Text = ""
                txt_parent.Text = ""


                txt_telephone.Text = ""
                txt_year.Text = ""
                txt_term.Text = ""
                txt_sname.Text = ""
                PictureBox1.Refresh()
                PictureBox1.Image = Nothing

                mycon.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)




            End Try
        Else
            MessageBox.Show("None of the fields should be blank")
        End If


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
           
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub UPLOADSTUDENTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPLOADSTUDENTSToolStripMenuItem.Click
        importexcel.Show()

    End Sub
End Class